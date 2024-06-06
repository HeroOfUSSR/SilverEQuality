using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Series;
using SilverEQuality.Forms;
using SilverEQuality_Context;
using SilverEQuality_Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverEQuality.FramesUC
{
    public partial class GraphFrame : UserControl
    {
        private bool onActualGraph = true;
        private bool onNormGraph = true;

        private bool searchDate = false;

        private DateTime fromDate;
        private DateTime toDate;
        public GraphFrame()
        {
            InitializeComponent();

            comboBoxUnits.DisplayMember = "Text";
            comboBoxUnits.ValueMember = "Value";

            comboBoxUnits.Items.Add(new { Text = "Серебро", Value = 0 });
            comboBoxUnits.Items.Add(new { Text = "Деньги", Value = 1 });

            comboBoxUnits.SelectedIndex = 0;

            fromDate = dateTimePickerStart.Value;
            toDate = dateTimePickerEnd.Value;
        }

        private void GraphFrame_Load(object sender, EventArgs e)
        {
            UnitGraph();

        }

        private void UnitGraph()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                /*if (graphView.Model.Series == null)
                {
                    graphView.Model.Series.Clear();
                }*/

                graphView.Model = new OxyPlot.PlotModel { Title = "Выручка" };

                FunctionSeries actualExp = new FunctionSeries();
                FunctionSeries normExp = new FunctionSeries();

                var checkGraph = db.Checks.Include(x => x.DecimalCheckNavigation)
                   .Include(x => x.SilverTypeCheckNavigation).ToList();

                if (searchDate)
                {
                    checkGraph = db.Checks.Include(x => x.DecimalCheckNavigation)
                    .Include(x => x.SilverTypeCheckNavigation)
                    .Where(x => x.DateCheck >= fromDate && x.DateCheck <= toDate)
                    .ToList();
                }

                var i = 0;

                normExp.Color = OxyColor.FromRgb(200, 220, 255);
                actualExp.Color = OxyColor.FromRgb(200, 121, 121);


                foreach (var check in checkGraph)
                {
                    var checkNorm = db.Norms.FirstOrDefault(x => x.DecimalNorm == check.DecimalCheckNavigation.IdDecimal);

                    switch (comboBoxUnits.SelectedIndex)
                    {
                        case 0:

                            i++;

                            if (check.CoverageCheck != 0)
                            {
                                actualExp.Points.Add(new OxyPlot.DataPoint(i, Convert.ToDouble(check.NormCheck * check.CoverageCheck)));
                            }
                            else
                            {
                                actualExp.Points.Add(new OxyPlot.DataPoint(i, Convert.ToDouble(check.NormCheck)));
                            }

                            if (check.CoverageCheck != 0 && checkNorm != null)
                            {
                                normExp.Points
                                    .Add(new OxyPlot.DataPoint(i, Convert.ToDouble(checkNorm.TitleNorm * check.CoverageCheck)));
                            }
                            else if (checkNorm != null)
                            {
                                normExp.Points.Add(new OxyPlot.DataPoint(i, Convert.ToDouble(checkNorm.TitleNorm)));
                            }
                            else
                            {
                                normExp.Points.Add(new OxyPlot.DataPoint(i, 0));
                            }

                            break;
                        case 1:

                            i++;

                            if (check.CoverageCheck != 0)
                            {
                                actualExp.Points.Add(new OxyPlot.DataPoint(i, Convert.ToDouble(check.NormCheck * check.CoverageCheck * check.SilverTypeCheckNavigation.CostPerKgSilverType)));
                            }
                            else
                            {
                                actualExp.Points.Add(new OxyPlot.DataPoint(i, Convert.ToDouble(check.NormCheck * check.SilverTypeCheckNavigation.CostPerKgSilverType)));
                            }

                            if (check.CoverageCheck != 0 && checkNorm != null)
                            {
                                normExp.Points
                                    .Add(new OxyPlot.DataPoint(i, Convert.ToDouble(checkNorm.TitleNorm * check.CoverageCheck * check.SilverTypeCheckNavigation.CostPerKgSilverType)));
                            }
                            else if (checkNorm != null)
                            {
                                normExp.Points.Add(new OxyPlot.DataPoint(i, Convert.ToDouble(checkNorm.TitleNorm * check.SilverTypeCheckNavigation.CostPerKgSilverType)));
                            }
                            else
                            {
                                normExp.Points.Add(new OxyPlot.DataPoint(i, 0));
                            }
                            break;
                        default:
                            break;
                    }
                }

                if (onActualGraph) graphView.Model.Series.Add(actualExp);

                if (onNormGraph) graphView.Model.Series.Add(normExp);

            }
        }


        private void buttonApply_Click(object sender, EventArgs e)
        {
            UnitGraph();
        }

        private void buttonOffActual_Click(object sender, EventArgs e)
        {
            onActualGraph = !onActualGraph;

            if (onActualGraph)
            {
                buttonOffActual.Text = "ВКЛ";
            }
            else
            {
                buttonOffActual.Text = "ВЫКЛ";
            }
        }

        private void buttonOffNorms_Click(object sender, EventArgs e)
        {
            onNormGraph = !onNormGraph;

            if (onNormGraph)
            {
                buttonOffNorms.Text = "ВКЛ";
            }
            else
            {
                buttonOffNorms.Text = "ВЫКЛ";
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            fromDate = dateTimePickerStart.Value;
            if (fromDate.ToString("d") == toDate.ToString("d"))
            {
                searchDate = false;
            }
            else
            {
                searchDate = true;
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            toDate = dateTimePickerEnd.Value;
            if (fromDate.ToString("d") == toDate.ToString("d"))
            {
                searchDate = false;
            }
            else
            {
                searchDate = true;
            }
        }

        private void GraphFrame_Resize(object sender, EventArgs e)
        {
            if (MainForm.isMenuExpanded)
            {
                labelActual.Visible = true;
                labelNorm.Visible = true;
            }
            else
            {
                labelActual.Visible = false;
                labelNorm.Visible = false;
            }
        }
    }
}
