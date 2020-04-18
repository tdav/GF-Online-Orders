# Txt

    Info
        https://blog.rsuter.com/automatically-migrate-your-entity-framework-core-managed-database-on-asp-net-core-application-start/


Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJyb2xlIjoiOTk5OzE7MjszOyIsIm5iZiI6MTU4NzEyNzE1OCwiZXhwIjoxNTg3NzMxOTU4LCJpYXQiOjE1ODcxMjcxNTh9.8nuGji_vY6Io4v_GJafSm1R6sWA3s8fd9_YZoleFd0w

Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjMiLCJyb2xlIjoiMTsiLCJuYmYiOjE1ODcwNzIyNDUsImV4cCI6MTU4NzY3NzA0NSwiaWF0IjoxNTg3MDcyMjQ1fQ.HVzw4Or0s1w_UbHX1aZRHn8vTd0EhcEXnK3ob9sd6mU

dotnet ef dbcontext scaffold "Server=localhost;Database=ef;User=root;Password=123456;TreatTinyAsBoolean=true;" "Pomelo.EntityFrameworkCore.MySql"



    INSTALL POSTGRESS 12
        https://computingforgeeks.com/how-to-install-postgresql-12-on-centos-7/

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
            pg_dump -h localhost -U davron orders > dbname.bak

        RESTORE DB
            psql -h localhost -U davron orders < dbname.bak


    FATAL-IDENT-AUTHENTICATION-FAILED-FOR-USER-UNABLE-TO-CONNECT-TO-POSTGRESQL
        https://confluence.atlassian.com/bitbucketserverkb/fatal-ident-authentication-failed-for-user-unable-to-connect-to-postgresql-779171564.html

        nano /etc/postgresql/9.3/main/pg_hba.conf
        local	all	all	trust
        host	all	127.0.0.1/32	trust
        sudo systemctl restart postgresql-12


    FIREWALL
        firewall-cmd --zone=public --add-port=25002/tcp --permanent
	    firewall-cmd --reload

    Host ASP.NET Core on Linux with Nginx
        https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx?view=aspnetcore-3.1


    Ports
        Web App        - 80, 443 
        Web Api Server - 25002
        pgAdmin        - 35002





    Init Postgres 12
        sudo su - postgres 
        psql -c "alter user postgres with password 'grand_online_orders'" 
        psql -c "CREATE ROLE davron WITH LOGIN CREATEDB ENCRYPTED PASSWORD 'grand_online_orders'"
        sudo systemctl restart postgresql-12





























