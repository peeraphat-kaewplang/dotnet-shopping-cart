Dockrt
    -docker run --name dotnettest --rm -p 3306:3306 -e MYSQL_ROOT_PASSWORD=vpkdwxwso001 -d mysql

dotnet tool install --global dotnet-ef

dotnet ef database update  

dotnet watch