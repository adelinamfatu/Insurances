using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsigurariDeViataSiBunuri
{
    public partial class Info : Form
    {
        List<Insurance> insurances = new List<Insurance>();
        public Info(List<Insurance> insurances)
        {
            InitializeComponent();
            this.insurances = insurances;
            foreach(Insurance i in insurances)
            {
                ListViewItem item = new ListViewItem(i.Type);
                item.SubItems.Add(i.Period.ToString());
                item.SubItems.Add(i.Price.ToString());
                item.SubItems.Add((i.Price / i.Period).ToString());
                lvInsurances.Items.Add(item);
            }
        }
    }
}
