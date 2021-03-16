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
    public partial class FrmOrdenar : Form
    {
        public FrmOrdenar()
        {
            InitializeComponent();
        }

        #region Events
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            OpenFrmInicial();
        }

        private void FrmOrdenar_Load(object sender, EventArgs e)
        {
            LoadEntrada();
            LoadPostre();
            LoadPlatoFuerte();
            LoadBebida();
        }
        #endregion

        #region Methods
        public void OpenFrmInicial()
        {
            FrmPrincipal.Instancia.Show();
            this.Close();
        }

        public void LoadEntrada()
        {
            CajaItemes PorDefecto = new CajaItemes();
            PorDefecto.Text = "";
            PorDefecto.Value = null;

            CajaItemes Entrante1 = new CajaItemes
            {
                Text = "Sopa",
                Value = 1,

            };

            CajaItemes Entrante2 = new CajaItemes
            {
                Text = "Sushi roll",
                Value = 2
            };

            CajaItemes Entrante3 = new CajaItemes
            {
                Text = "Ensalada Caesar ",
                Value = 3
            };

            CajaItemes Entrante4 = new CajaItemes
            {
                Text = "Croquetas",
                Value = 4
            };

            CajaItemes Entrante5 = new CajaItemes
            {
                Text = "Entradita de camarones",
                Value = 5
            };


            CmbEntrada.Items.Add(PorDefecto);
            CmbEntrada.Items.Add(Entrante1);
            CmbEntrada.Items.Add(Entrante2);
            CmbEntrada.Items.Add(Entrante3);
            CmbEntrada.Items.Add(Entrante4);
            CmbEntrada.Items.Add(Entrante5);
            CmbEntrada.SelectedItem = PorDefecto;

        }

        public void LoadPlatoFuerte()
        {
            CajaItemes PorDefault = new CajaItemes();
            PorDefault.Text = "";
            PorDefault.Value = null;

            CajaItemes str1 = new CajaItemes
            {
                Text = "Lasaña",
                Value = 1,

            };

            CajaItemes str2 = new CajaItemes
            {
                Text = "Espagueti a la bolognesa",
                Value = 2
            };

            CajaItemes str3 = new CajaItemes
            {
                Text = "T Bone Steak",
                Value = 3
            };

            CajaItemes str4 = new CajaItemes
            {
                Text = "Nueva york 8 onz",
                Value = 4
            };

            CajaItemes str5 = new CajaItemes
            {
                Text = "Pechuga a la plancha",
                Value = 5
            };
            CajaItemes str6 = new CajaItemes
            {
                Text = "Pechuga a la gordonblue",
                Value = 6
            };
            CajaItemes str7 = new CajaItemes
            {
                Text = "Picaña A la parrilla",
                Value = 7
            };
            CajaItemes str8 = new CajaItemes
            {
                Text = "Hamburguesa doble",
                Value = 8
            };
            CajaItemes str9 = new CajaItemes
            {
                Text = "El Rompeestomagos",
                Value = 9
            };
            CajaItemes str10 = new CajaItemes
            {
                Text = "Moro de Guandule",
                Value = 10
            };


            CmbxPlatosFuertes.Items.Add(PorDefault);
            CmbxPlatosFuertes.Items.Add(str1);
            CmbxPlatosFuertes.Items.Add(str2);
            CmbxPlatosFuertes.Items.Add(str3);
            CmbxPlatosFuertes.Items.Add(str4);
            CmbxPlatosFuertes.Items.Add(str5);
            CmbxPlatosFuertes.Items.Add(str6);
            CmbxPlatosFuertes.Items.Add(str7);
            CmbxPlatosFuertes.Items.Add(str8);
            CmbxPlatosFuertes.Items.Add(str9);
            CmbxPlatosFuertes.Items.Add(str10);
            CmbxPlatosFuertes.SelectedItem = PorDefault;

        }

        public void LoadBebida()
        {
            CajaItemes PorDefecto = new CajaItemes();
            PorDefecto.Text = "";
            PorDefecto.Value = null;

            CajaItemes Bebida1 = new CajaItemes
            {
                Text = "Limonada",
                Value = 1,

            };

            CajaItemes Bebida2 = new CajaItemes
            {
                Text = "Cerveza Artesanal",
                Value = 2
            };

            CajaItemes Bebida3 = new CajaItemes
            {
                Text = "Colcacola",
                Value = 3
            };

            CajaItemes Bebida4 = new CajaItemes
            {
                Text = "Batido de guineo",
                Value = 4
            };

            CajaItemes Bebida5 = new CajaItemes
            {
                Text = "Agua",
                Value = 5
            };


            CmbBebida.Items.Add(PorDefecto);
            CmbBebida.Items.Add(Bebida1);
            CmbBebida.Items.Add(Bebida2);
            CmbBebida.Items.Add(Bebida3);
            CmbBebida.Items.Add(Bebida4);
            CmbBebida.Items.Add(Bebida5);
            CmbBebida.SelectedItem = PorDefecto;

        }

        public void LoadPostre()
        {
            CajaItemes PorDefecto = new CajaItemes();
            PorDefecto.Text = "";
            PorDefecto.Value = null;

            CajaItemes Postre1 = new CajaItemes
            {
                Text = "Flan de leche",
                Value = 1,

            };

            CajaItemes Postre2 = new CajaItemes
            {
                Text = "Dulce de coco ",
                Value = 2
            };

            CajaItemes Postre3 = new CajaItemes
            {
                Text = "Nutella con palitos de queso",
                Value = 3
            };

            CajaItemes Postre4 = new CajaItemes
            {
                Text = "Tres Leche",
                Value = 4
            };

            CajaItemes Postre5 = new CajaItemes
            {
                Text = "Gominolas",
                Value = 5
            };


            CmbPostre.Items.Add(PorDefecto);
            CmbPostre.Items.Add(Postre1);
            CmbPostre.Items.Add(Postre2);
            CmbPostre.Items.Add(Postre3);
            CmbPostre.Items.Add(Postre4);
            CmbPostre.Items.Add(Postre5);
            CmbPostre.SelectedItem = PorDefecto;

        }




        #endregion

        

        
    }
}
