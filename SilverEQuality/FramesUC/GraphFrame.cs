using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Series;
using SilverEQuality_Context;
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
        public GraphFrame()
        {
            InitializeComponent();
        }

        private void GraphFrame_Load(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                graphView.Model = new OxyPlot.PlotModel { Title = "Выручка" };

                FunctionSeries actualExp = new FunctionSeries();
                FunctionSeries normExp = new FunctionSeries();
                var checkGraph = db.Checks.Include(x => x.DecimalCheckNavigation).ToList();
                var i = 0;

                normExp.Color = OxyColor.FromRgb(200, 220, 255);
                actualExp.Color = OxyColor.FromRgb(200, 121, 121);

                foreach (var check in checkGraph)
                {
                    var checkNorm = db.Norms.FirstOrDefault(x => x.DecimalNorm == check.DecimalCheckNavigation.IdDecimal);
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
                }

                graphView.Model.Series.Add(actualExp);
                graphView.Model.Series.Add(normExp);

            }
            
             

        }
    }
}
