using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Being
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            var conversa = new Conversa
            {
                Mensagem = Mensagem.Text
            };

            Mensagem.Text = "";
            MinhaMensagem.Text = conversa.Mensagem;
            conversa.getRespostaBot();
            Resposta.Text = conversa.Resposta;
        }
    }
}
