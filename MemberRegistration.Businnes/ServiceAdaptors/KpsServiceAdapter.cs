using MemberRegistration.Businnes.KpsServiceReference;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Businnes.ServiceAdaptors
{
    public class KpsServiceAdapter : IKpsServiceAdapter
    {
        public bool ValidateUser(Member member)
        {
            //bu service büyük harf kabul ediyor o yüzden toUpper ekledik.
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo), member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year);
        }
    }
}
