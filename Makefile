
build:
	' nombre del usurario/proyectocolprofesionales .
	docker build -t anderson807/proyectocolprofesionales .

tag:
	docker tag proyectocolprofesionales anderson807/proyectocolprofesionales:latest

login:
	docker login

push:
	docker push anderson807/proyectocolprofesionales:latest

run:
	docker run -d -p 8080:80 --name my_server anderson807/proyectocolprofesionales:latest
	