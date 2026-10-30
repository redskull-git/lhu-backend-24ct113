using AspNetCoreRateLimit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// 1. Cần bộ nhớ đệm (Memory Cache) để lưu số lần request
builder.Services.AddMemoryCache();

// 2. Nạp cấu hình từ appsettings.json vào IpRateLimitOptions
builder.Services.Configure<IpRateLimitOptions>(builder.Configuration.GetSection("IpRateLimiting"));

// 3. Đăng ký các dịch vụ Rate Limiting vào DI Container
builder.Services.AddInMemoryRateLimiting();
builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();

var app = builder.Build();

// Configure the HTTP request pipeline.

// 4. Kích hoạt Middleware giới hạn tần suất yêu cầu (phải đặt trước UseAuthorization/MapControllers)
app.UseIpRateLimiting();

app.UseAuthorization();

app.MapControllers();

app.Run();
