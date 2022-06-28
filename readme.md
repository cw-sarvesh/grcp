# Steps to reproduce gRPC from scratch

In case of any code brake visit here <https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-6.0&tabs=visual-studio-code>

1. dotnet new grpc -o GrpcGreeterService
2. then come outside of GrpcGreeterService directory.
3. dotnet new console -o GrpcGreeterClient
4. Add Nuget package for gRPC.
5. dotnet add GrpcGreeterClient.csproj package Grpc.Net.Client
dotnet add GrpcGreeterClient.csproj package Google.Protobuf
dotnet add GrpcGreeterClient.csproj package Grpc.Tools.
6. Create Protos folder and copy file from Service proto dir. Change namespace in client project proto file option csharp_namespace = "GrpcGreeterClient";.
7. Select the GrpcGreeterClient.csproj file.
8. Add this 
<code>
<ItemGroup>
  <Protobuf Include="Protos\greet.proto" GrpcServices="Client" />
</ItemGroup>
</code>
9. <https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-6.0&tabs=visual-studio-code#create-the-greeter-client>
10. Start the Greeter service.
Start the client.
