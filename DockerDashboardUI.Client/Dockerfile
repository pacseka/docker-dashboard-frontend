FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DockerDashboardUI.Client/DockerDashboardUI.Client.csproj", "DockerDashboardUI.Client/"]
RUN dotnet restore "DockerDashboardUI.Client/DockerDashboardUI.Client.csproj"
COPY . .
RUN dotnet build "DockerDashboardUI.Client/DockerDashboardUI.Client.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR "/src/DockerDashboardUI.Client"
RUN dotnet publish "DockerDashboardUI.Client.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
COPY --from=publish /app/publish/wwwroot /usr/share/nginx/html/
COPY ["DockerDashboardUI.Client/nginx.include.conf",  "/etc/nginx/nginx.include.conf"]
COPY ["DockerDashboardUI.Client/nginx.conf",  "/etc/nginx/nginx.conf"]