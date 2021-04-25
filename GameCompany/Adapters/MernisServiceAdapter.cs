using GameCompany.Abstract;
using GameCompany.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(user.NationalityId, user.Name.ToUpper(), user.Surname.ToUpper(), user.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
