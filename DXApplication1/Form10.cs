using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form10 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form10()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                comboBoxEdit1.Properties.Items.Add(cnt.SkinName);
            }  


        }

        private void btnb_Click(object sender, EventArgs e)
        {
            defaultLookAndFeel2.LookAndFeel.SkinName = comboBoxEdit1.SelectedText;
            lab.Text = comboBoxEdit1.SelectedText;
        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
