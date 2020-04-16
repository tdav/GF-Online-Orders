# Txt

Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJyb2xlIjoiOTk5OzE7MjszOyIsIm5iZiI6MTU4NzA3MTcxMiwiZXhwIjoxNTg3Njc2NTEyLCJpYXQiOjE1ODcwNzE3MTJ9.cNqUAsrPMPaVXSO7NROrQ77Jjpfsq3NGRTwhRABBs8Q

Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMiLCJyb2xlIjoiMTsiLCJuYmYiOjE1ODcwNzIyNDUsImV4cCI6MTU4NzY3NzA0NSwiaWF0IjoxNTg3MDcyMjQ1fQ.HVzw4Or0s1w_UbHX1aZRHn8vTd0EhcEXnK3ob9sd6mU

dotnet ef dbcontext scaffold "Server=localhost;Database=ef;User=root;Password=123456;TreatTinyAsBoolean=true;" "Pomelo.EntityFrameworkCore.MySql"

 CREATE ROLE davron WITH LOGIN CREATEDB ENCRYPTED PASSWORD 'grand_online_orders';

 CREATE DATABASE orders WITH OWNER davron;


 psql -h localhost -U davron -d orders -a -f init_db.sql



  psql -h localhost -U davron postgres

   drop database orders;


 CREATE DATABASE orders
    WITH 
    OWNER = davron
    ENCODING = 'UTF8';

BAKCUP DB
    pg_dump -U davron orders > dbname.bak

RESTORE DB
    psql -h localhost -U davron orders < dbname.bak



