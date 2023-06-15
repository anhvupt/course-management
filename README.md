# Course-web-api
The course management system is a study project implements basic CRUD operations & JWT authentication, built with Angular, .NET, MySql and containerized by Docker.

The system allows instructors to create and manage courses and students to enroll in courses. Key features include:

+ Instructor can create, update and delete courses
+ Students can enroll and drop courses

### TODO
+ Add tests for both .NET and Angular projects
+ Implement state management using ngrx (currently using services with Subjects)
+ Fix Auth bugs :P

✅ Update to .NET6

✅ Update to Angular v16

✅ Build with Docker

# With Docker
+ Ensure that you have Docker on your computer
+ Run ```docker-compose up``` from the root directory

# Without Docker
## -> Backend set up

### 1. Restore packages
Run ``` dotnet restore ```

### 2. Connect to database
Create your database and replace the connection string in ```appsettings.json``` file

### 3. Update database
In package manager console, run ```update-database```

## -> Frontend set up

### Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

### Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

### Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

### Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

### Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

### Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).
