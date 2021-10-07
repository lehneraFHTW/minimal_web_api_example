using minimal_api_new;

var app = WebApplication.Create(args);

var DataManager = new DataManager();

app.MapGet("/", () => "Hello World");
app.MapGet("/getEmployees",()=> DataManager.GetEmployees());
app.MapPut("/addEmployee", async (http) =>
    {
        var inputNewEmployee = new StreamReader(http.Request.Body).ReadToEndAsync();
        try
        {
            DataManager.AddEmployess(inputNewEmployee.Result);
            http.Response.StatusCode = 204;
        }catch (Exception ex)
        {
            http.Response.StatusCode = 500;
            await http.Response.WriteAsync(ex.Message);
        }
    });
await app.RunAsync();

