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
    public partial class NormFrame : UserControl
    {
        public NormFrame()
        {
            InitializeComponent();
            InitDatagrid();
        }

        private void InitDatagrid()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var result = from norm in db.Norms
                             .Where(x => x.DecimalNormNavigation.TitleDecimal.Contains(textBoxSearch.Text)
                             || x.SilverTypeNormNavigation.TitleSilverType.Contains(textBoxSearch.Text)
                             || textBoxSearch.Text == "")
                             select new
                             {
                                 DecimalNorm = norm.DecimalNormNavigation.TitleDecimal,
                                 SilverTypeNorm = norm.SilverTypeNormNavigation.TitleSilverType,
                                 TitleNorm = norm.TitleNorm,
                             };

                if (result.Any())
                {
                    dataGridViewNorm.DataSource = result.ToList();

                    dataGridViewNorm.Columns["DecimalNorm"].HeaderText = "Децимальный номер";
                    dataGridViewNorm.Columns["SilverTypeNorm"].HeaderText = "Вид серебра";
                    dataGridViewNorm.Columns["TitleNorm"].HeaderText = "Норма";


                }
            }
        }
    }
}
