using DevFramework.Core.Aspects.PostSharp.ValidationAspects;
using MemberRegistration.Businnes.Abstract;
using MemberRegistration.Businnes.ServiceAdaptors;
using MemberRegistration.Businnes.ValidationRules.FluentValidation;
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
        private readonly IKpsServiceAdapter _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsServiceAdapter kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }
        [FluentValidationAspect(typeof(MemberValidator))]
        public void AddMember(Member member)
        {
            CheckMemberExists(member);
            CheckUserValidFromKps(member);
            _memberDal.Add(member);
        }

        private void CheckUserValidFromKps(Member member)
        {
            //kullanıcı doğrulaması geçerli mi kps'den sorgulama
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanıcı doğrulaması geçerli değil.");
            }
        }

        private void CheckMemberExists(Member member)
        {
            //aynı tc'den varsa kaydetmeyeceğiz
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("Kullanıcı zaten kayıtlı.");
            }
        }
    }
}
