using MemberRegistration.Businnes.Abstract;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Businnes.Concrete
{
    public class MemberManager : IMemberService
    {
        private readonly IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void AddMember(Member member)
        {
            //üye eklerken validasyon yapmamız gerek bunun için microservice mimarisine uygun işlem service implemente edeceğiz.
            _memberDal.Add(member);
        }
    }
}
