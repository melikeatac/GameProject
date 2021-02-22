using GameProject.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService

    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                    (new TCKimlikNoDogrulaRequestBody(gamer.NationalId, gamer.GamerName,
                    gamer.GamerSurname, gamer.DateofBirth))).Result.Body.TCKimlikNoDogrulaResult;
                }
    }
}
