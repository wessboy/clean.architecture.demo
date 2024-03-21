
namespace Member.Application
{
    public class MemberService : IMemberService
    {
        private   readonly ImemberRepository _memberRepository;
        public MemberService(ImemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
            
        }
        public List<Domain.Member> GetAllMembers()
        {
            return _memberRepository.GetAllMembers();
        }
    }
}
