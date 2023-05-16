FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /
COPY --from=build /out .
ENV ConnectionStrings__Default=server=127.0.0.1;uid=root;pwd=admin;database=course-data

ENTRYPOINT ["dotnet", "CourseWebAPI.dll"]
