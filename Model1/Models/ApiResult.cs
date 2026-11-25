namespace Model1.Models
{
    public class ApiResult
    {
        public int code { get; set; }
        public string msg { get; set; } = "";

        public object? Data { get; set; }
        public static ApiResult Ok(object? d = null) =>
            new ApiResult
            {
                code = 200,
                msg = "Success",
                Data = d
            };
         public static ApiResult Fail(int c ,string m) =>
            new ApiResult { code = c , msg = m };
        
    }
}
