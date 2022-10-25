using appPrevencionRiesgos.Model;

using appPrevencionRiesgos.Services;


var builder = WebApplication.CreateBuilder(args);

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => { options.AllowAnyOrigin(); options.AllowAnyMethod(); options.AllowAnyHeader(); });
});


builder.Services.AddControllers();



//builder.Services.AddTransient<IMongoDBServices, MongoDBService>();
builder.Services.AddSingleton<IMongoDBServices, MongoDBService>();
builder.Services.AddScoped<IMongoDBServices, MongoDBService>();

var aux = config.GetRequiredSection("MongoDB");
MongoDBSettings dbConf = new MongoDBSettings() ;
dbConf.ConnectionURI = aux["ConnectionURI"];
dbConf.DatabaseName = aux["DatabaseName"];
dbConf.CollectionName = aux["CollectionName"];
//Console.WriteLine(dbConf);

//builder.Services.Configure<MongoDBService>(dbConf);
//builder.Services.AddDefaultIdentity<IdentityUser>()
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));

//Console.WriteLine();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options => { options.AllowAnyOrigin(); options.AllowAnyMethod(); options.AllowAnyHeader(); });

app.UseAuthorization();

app.MapControllers();

app.Run();


