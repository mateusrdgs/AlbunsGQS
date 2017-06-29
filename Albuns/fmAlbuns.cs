using Albuns.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albuns
{
    public partial class fmAlbuns : Form
    {
        Album novoAlbum;

        public fmAlbuns()
        {
            InitializeComponent();            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            novoAlbum = new Album();

            try
            {
                if(Auxilio.validarCampoTexto(tbTitulo.Text))               
                    novoAlbum.Titulo = Auxilio.removerEspacos(tbTitulo.Text);
                else
                    throw new Exception("Campo 'Título' inválido");

                if (Auxilio.validarCampoTexto(tbArtista.Text))
                    novoAlbum.Artista = Auxilio.removerEspacos(tbArtista.Text);
                else
                    throw new Exception("Campo 'Artista' inválido");

                if (Auxilio.validarCampoTexto(tbGravadora.Text))
                    novoAlbum.Gravadora = Auxilio.removerEspacos(tbGravadora.Text);
                else
                    throw new Exception("Campo 'Gravadora' inválido");

                if (Auxilio.validarCampoTexto(tbGenero.Text))
                    novoAlbum.Genero = Auxilio.removerEspacos(tbGenero.Text);
                else
                    throw new Exception("Campo 'Gênero' inválido");

                if (Auxilio.validarCampoTexto(mtbFaixas.Text))
                    novoAlbum.Faixas = Auxilio.retornarNumero(mtbFaixas.Text);

                if (Auxilio.validarCampoTexto(mtbAno.Text))
                    novoAlbum.Ano = Auxilio.retornarAno(mtbAno.Text);
                else
                    throw new Exception("Campo 'Ano de lançamento' inválido");
                 
                adicionarNovoAlbum(novoAlbum);
                limparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void adicionarNovoAlbum(Album album)
        {
            dgvAlbuns.Rows.Add(new object[]
            {
                album.Titulo,
                album.Artista,
                album.Gravadora,
                album.Genero,
                album.Faixas,
                album.Ano
            });
        }

        private void limparFormulario()
        {
            foreach (Control control in gbAlbuns.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                    control.ResetText();
            }
        }

        private void focus(Control component)
        {
            component.Focus();
        }
    }
}
