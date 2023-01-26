using OCPI;

var builder = WebApplication.CreateBuilder(args);

// Add all required OCPI services to your application
builder.AddOcpi();

var app = builder.Build();

app.UseOcpiExceptionHandler();
app.MapControllers();
app.FetchOcpiVersions();

app.Run();