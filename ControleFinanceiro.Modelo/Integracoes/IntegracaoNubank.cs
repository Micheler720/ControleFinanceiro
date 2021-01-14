using ControleFinanceiro.Modelo.Entidades;
using NubankClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Modelo.Integracoes
{
    internal class IntegracaoNubank
    {
        internal string Mensagem;

        internal async Task<bool> Integrar(Integracao Dados)
        {

            var nubankClient = new Nubank(Dados.Usuario, Dados.Senha);
            var loginResponse = await nubankClient.LoginAsync();
            if (loginResponse.NeedsDeviceAuthorization)
            {
                var qrcode = loginResponse.GetQrCodeAsAscii();
                // Here you can get qrcode as bitmap too.
                // var qrcode = loginResponse.GetQrCodeAsBitmap();
                // Now the user needs to scan QRCode using your device.
                // The user needs to access nubank in his smartphone and navigate to menu: Nu(Seu Nome) > Perfil > Acesso pelo site.
                // After user scan QRCode:
                await nubankClient.AutenticateWithQrCodeAsync(loginResponse.Code);
                Mensagem = "Integrado";
                return true;
            }
            Mensagem = "Erro";
            return false;
        }
    }
}
