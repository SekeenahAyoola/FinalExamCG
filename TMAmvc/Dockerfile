# Use a specific .NET SDK image as the base
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory
WORKDIR /TMAmvc

# Copy the csproj and restore dependencies
COPY ["TMAmvc.csproj", "TMAmvc/"]
RUN dotnet restore

# Copy the rest of the project
COPY . .

# Build the application
RUN dotnet publish -c Release -o out

# Build a runtime image, based on a minimal .NET image
FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Set the working directory
WORKDIR /TMAmvc

# Copy the published application from the build stage
COPY --from=build-env /TMAmvc/out .

# Expose the port used by the application (adjust if needed)
EXPOSE 8080

# Define the command to run the application
ENTRYPOINT ["dotnet", "TMAmvc.dll"]