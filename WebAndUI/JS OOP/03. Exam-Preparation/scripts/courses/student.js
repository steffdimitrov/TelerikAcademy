/// <reference path="../libs/requirejs/require.js" />
define(function () {
    var Student;
    Student = (function(){
        function Student(information) {
            this.name = information.name;
            this.exam = information.exam;
            this.homework = information.homework;
            this.attendance = information.attendance;
            this.teamwork = information.teamwork;
            this.bonus = information.bonus;
        }

        return Student
}());
    return Student;
});