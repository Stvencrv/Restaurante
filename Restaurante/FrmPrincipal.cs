using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.ComboBox;

namespace Restaurante
{
    public sealed partial class FrmPrincipal : Form
    {
        
      
        public static FrmPrincipal Instancia { get; } = new FrmPrincipal();
        private FrmPrincipal()
        {
            InitializeComponent();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
        #region Events
        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            OpenFrmPedir();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadMesaBx();
            LoadCantidadPersonaBx();
        }
        #endregion

        public void OpenFrmPedir()
        {
            CajaItemes CompararMesas = (CajaItemes)CmbxSelecciondemesa.SelectedItem;
            CajaItemes CompararCantidad = (CajaItemes)CmbxSeleccionaCantidad.SelectedItem;

            if (CompararMesas.Value != null)
            {
                if (CompararCantidad.Value != null)
                {
                    FrmOrdenar OpenForm = new FrmOrdenar();
                    OpenForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado una cantidad de personas");
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado una mesa");
            }
           
        }

        public void LoadMesaBx()
        {
            CajaItemes PorDefecto = new CajaItemes();
            PorDefecto.Text = "";
            PorDefecto.Value = null;

            CajaItemes Mesa1 = new CajaItemes
            {
                Text = "Mesa 1",
                Value = 1,
                
            };

            CajaItemes Mesa2 = new CajaItemes
            {
                Text = "Mesa 2",
                Value = 2
            };

            CajaItemes Mesa3 = new CajaItemes
            {
                Text = "Mesa 3",
                Value = 3
            };

            CajaItemes Mesa4 = new CajaItemes
            {
                Text = "Mesa 4",
                Value = 4
            };

            CajaItemes Mesa5 = new CajaItemes
            {
                Text = "Mesa 5",
                Value = 5
            };

            CajaItemes Mesa6 = new CajaItemes
            {
                Text = "Mesa 6",
                Value = 6
            };

            CajaItemes Mesa7 = new CajaItemes
            {
                Text = "Mesa 7",
                Value = 7
            };

            CajaItemes Mesa8 = new CajaItemes
            {
                Text = "Mesa 8",
                Value = 8
            };

            CmbxSelecciondemesa.Items.Add(PorDefecto);
            CmbxSelecciondemesa.Items.Add(Mesa1);
            CmbxSelecciondemesa.Items.Add(Mesa2);
            CmbxSelecciondemesa.Items.Add(Mesa3);
            CmbxSelecciondemesa.Items.Add(Mesa4);
            CmbxSelecciondemesa.Items.Add(Mesa5);
            CmbxSelecciondemesa.Items.Add(Mesa6);
            CmbxSelecciondemesa.Items.Add(Mesa7);
            CmbxSelecciondemesa.Items.Add(Mesa8);
            CmbxSelecciondemesa.SelectedItem = PorDefecto;
            
        }

        public void LoadCantidadPersonaBx()
        {
            CajaItemes PorDefecto = new CajaItemes();
            PorDefecto.Text = "";
            PorDefecto.Value = null;

            CajaItemes Persona1 = new CajaItemes
            {
                Text = "1 Persona",
                Value = 1
            };
            CajaItemes Persona2 = new CajaItemes
            {
                Text = "2 Personas",
                Value = 2
            };
            CajaItemes Persona3 = new CajaItemes
            {
                Text = "3 Personas",
                Value = 3
            };
            CajaItemes Persona4 = new CajaItemes
            {
                Text = "4 Personas",
                Value = 4
            };

            CmbxSeleccionaCantidad.Items.Add(PorDefecto);
            CmbxSeleccionaCantidad.Items.Add(Persona1);
            CmbxSeleccionaCantidad.Items.Add(Persona2);
            CmbxSeleccionaCantidad.Items.Add(Persona3);
            CmbxSeleccionaCantidad.Items.Add(Persona4);
            CmbxSeleccionaCantidad.SelectedItem = PorDefecto;
            
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
