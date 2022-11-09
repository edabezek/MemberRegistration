using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Businnes.Abstract
{
    public interface IMemberService
    {
        //üye ekleme işlemi yapacağız.
        void AddMember(Member member);
    }
}
