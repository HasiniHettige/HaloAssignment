using HaloAssignmentDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//API EndPoint
app.MapGet("/ManageConversions/GetWholeNumbers{text}", (string text) =>
{
    var output = ManageConversions.GetWholeNumbers(text);

    return output;

})
.WithName("GetWholeNumber2");

app.Run();
