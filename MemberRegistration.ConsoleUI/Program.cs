using MemberRegistration.Businnes.Abstract;
using MemberRegistration.Businnes.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService=InstanceFactory.GetInstance<IMemberService>();
            memberService.AddMember(new Member { FirstName="Eda",LastName="Bezek",Email="eda_bezek@hotmail.com",DateOfBirth=new DateTime(1993,4,27),TcNo="111111" });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
