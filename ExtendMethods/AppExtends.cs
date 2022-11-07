using System.Net;

namespace App.ExtendMethods
{
  public static class AppExtends
  {
    // UseStatusCodePages is middleware
    //    it will check response with status codes 400 - 599
    //    and create response body
    public static void AddStatusCodePage(this IApplicationBuilder app)
    {
      app.UseStatusCodePages(appError => {
        appError.Run(async context => {
          var response = context.Response;
          var code = response.StatusCode;

          var content = @$"
          <html>
            <head>
              <meta charset='UTF-8' />
              <title>Message { code }</title>
            </head>
            <body>
              <p>
                Status Code: { code } - { (HttpStatusCode)code }
              </p>
            </body>
          </html>";

          await response.WriteAsync(content);
        });
    });
    }
  }
}