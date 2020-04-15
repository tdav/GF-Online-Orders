
INSERT INTO orders.public.sp_roles(id, status, create_date, update_date, create_user, update_user, name, user_access) VALUES
(1, 1, '2020-04-14', null, 1, null, E'admin', E'999;1;');

INSERT INTO orders.public.sp_access_lists(id, status, create_date, update_date, create_user, update_user, name) VALUES
(1, 1, '2020-04-14', null, 1, null, E'admin');


INSERT INTO orders.public.tb_user(id, status, create_date, update_date, create_user, update_user, first_name, last_name, username, password, role_id) VALUES
(1, 1, '2020-04-14', null, 1, null, E'admin', E'admin', E'admin', E'2010',  1);


