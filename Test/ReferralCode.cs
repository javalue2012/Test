using System;
using System.Linq;
using static Test.User;

namespace Test
{
       public class ReferralCode : IUserMatcher
    {
        // cái này tau code ko biết đúng ko 
        //sợ sai => mi hiểu yêu cầu chỗ referal code ni ko 
        // tau hiểu là hấn so sánh 3 ký tự trùng thì bỏ qua
        // có mở đề ko . mà m đã hỏi về chỗ ni chưa
        // tau hỏi rồi mà chưa rep
        // hỏi 1 đống câu hỏi mà hcuwa rep
        // hỏi chiều thì mai họ trả lời chớ giờ nớ họ về rồi :)))
        //va thì tau hỏi là ở cái này check trùng 3 ký tự là tự reject phải ko
        // m hoir như rang
        // 3 characters of the referral code being reversed => hiểu câu ni ko
        // tau hiểu là có 3 ký tự á chữ reversed kìa ba dịch theo nghĩa bt chớ nghĩa của hấn ko rõ
        // nếu nghĩa của hắn là dịch ra như răng tức là luôn có 3 ký tự giống 
        // ý nó là như ri nè. 
        // cái referal code ni dc 1 bên khác generate. nhưng bên đó đang có 1 bug là 3 ký tự gần nhau bị đảo chiều. nghĩa là ví dụ user nhập ABC123 mi phải check nếu đã có CBA123 thì coi như trùng
        // cứ 3 ký tự thì nó sẽ bị đảo thằng đàu và cuối. hiểu hông nà . cái ni trùng 3 ký tự là được chứ ko nhất thiết là nằm kề nhau à
        // đau 
        // giờ nha cho ví dụ user nhập ABC123 thì những thằng dc cho là trùng sẽ là 
        // CAB123, A1CB23, AB21C3, ....
        // // đù khó rứa :)) mi hiểu 3 ký tự mà đảo chiều nó ra chi ko 
        // ABC đảo chiều là CBA 123 đảo chiều là 312 BC1 đảo chiều là 1CB  3 characters of the referral code being reversed cái ni nè 
        // giờ thì hiểu câu này rồi mà ko có hướng giải quyết
        //:)) tau code đếm có 3 ký tự trùng nhau trong dãy là false luoongiowf
        // giờ ri nừ 
        // 1 code kiểu tạo 1 cái function để tạo ra chuổi đảo chiều. rồi mi lặp từng ký tự trong cái

        public bool IsMatch(User newUser, User existingUser)
        {
            var srt1 ;
            var srt2;
            for (int i = 0; i < newUser.Address.StreetAddress.Count(); i++)
            {
                srt1 = newUser.Address.StreetAddress.Substring(i, 3);
                int l = srt1.Length - 1;
                for (i = l; i >= 0; i--)
                {
                    srt1 = srt1 + srt1[i];
                }
            }
            for (int i = 0; i < existingUser.Address.StreetAddress.Count(); i++)
            {
                 srt2 = existingUser.Address.StreetAddress.Substring(i, 3);

            }
           
            return srt1 == srt2;
        }
    }
}
