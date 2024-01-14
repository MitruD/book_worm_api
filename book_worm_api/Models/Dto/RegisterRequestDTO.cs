namespace book_worm_api.Models.Dto
{
    public class RegisterRequestDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        //Role should't be epoxet to production API, here is added for studying pourpose
        public string Role { get; set; }
    }
}
