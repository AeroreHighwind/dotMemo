namespace dotMemo.Models.Responses
{
    public class LoginResponseModel
    {
        public string _AccessToken { get; set; }
        public string _RefreshToken { get; set; }

        public bool _Success {  get; set; }

    }
}
