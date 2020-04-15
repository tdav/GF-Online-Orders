# Txt

dotnet ef dbcontext scaffold "Server=localhost;Database=ef;User=root;Password=123456;TreatTinyAsBoolean=true;" "Pomelo.EntityFrameworkCore.MySql"

 CREATE ROLE davron WITH LOGIN CREATEDB ENCRYPTED PASSWORD 'grand_online_orders';

 CREATE DATABASE orders WITH OWNER davron;



 psql -h localhost -U davron -d orders -a -f init_db.sql