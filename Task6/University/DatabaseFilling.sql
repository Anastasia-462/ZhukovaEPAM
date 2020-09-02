USE University;

INSERT INTO Groups(GroupName)
VALUES ('���-31');
INSERT INTO Groups(GroupName)
VALUES ('���-31');
INSERT INTO Groups(GroupName)
VALUES ('��-31');

INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('����������', '���������', '�������', '�', '2001-04-25', 1);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('������', '����', '���������', '�', '2000-09-02', 1);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('���������', '�����', '����������', '�', '2001-03-10', 1);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�����������', '������', '����������', '�', '2000-07-15', 1);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('����������', '������', '���������', '�', '2000-08-11', 1);

INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('���������', '�������', '��������', '�', '2001-05-21', 2);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�������', '�������', '���������', '�', '2000-10-02', 2);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�����������', '�����', '����������', '�', '2001-01-18', 2);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�������', '���������', '����������', '�', '2000-12-11', 2);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�����', '�����', '�����������', '�', '2000-04-16', 2);

INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�������', '���������', '�������', '�', '2001-05-29', 3);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�������', '������', '���������', '�', '2001-11-09', 3);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�������', '�����', '�������', '�', '2001-07-16', 3);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('���������', '���������', '����������', '�', '2000-06-14', 3);
INSERT INTO Students(Surname, Name, MiddleName, Gender, DateOfBirth, GroupId)
VALUES ('�������', '�����', '��������', '�', '2000-07-12', 3);

/*The first group*/
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-01-11', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '����������', '2020-01-18', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2020-01-24', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2019-12-24', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2019-12-26', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2019-12-28', '�', 1);

INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-06-09', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-06-16', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-06-21', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-05-25', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '�������', '2020-05-27', '�', 1);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2020-05-29', '�', 1);

/*The second group*/
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-01-10', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '����������', '2020-01-17', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2020-01-23', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2019-12-25', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2019-12-27', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2019-12-29', '�', 2);

INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-06-08', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2020-06-15', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-06-20', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-05-24', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '������', '2020-05-26', '�', 2);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-05-28', '�', 2);

/*The third group*/
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-01-09', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2020-01-16', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2020-01-22', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���������', '2019-12-20', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '�������', '2019-12-22', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���', '2019-12-24', '�', 3);

INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '���������', '2020-06-06', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '�����������', '2020-06-14', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '��', '2020-06-18', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '����������', '2020-05-20', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '������', '2020-05-22', '�', 3);
INSERT INTO Exams(AssessmentForm, SubjectName, ExamDate, Session, GroupId)
VALUES ('�', '�������', '2020-05-24', '�', 3);


/*The first group*/
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (1, 1, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (2, 1, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (3, 1, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (4, 1, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (5, 1, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (6, 1, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (7, 1, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (8, 1, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (9, 1, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (10, 1, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (11, 1, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (12, 1, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (1, 2, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (2, 2, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (3, 2, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (4, 2, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (5, 2, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (6, 2, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (7, 2, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (8, 2, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (9, 2, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (10, 2, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (11, 2, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (12, 2, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (1, 3, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (2, 3, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (3, 3, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (4, 3, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (5, 3, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (6, 3, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (7, 3, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (8, 3, 3);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (9, 3, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (10, 3, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (11, 3, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (12, 3, 2);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (1, 4, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (2, 4, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (3, 4, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (4, 4, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (5, 4, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (6, 4, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (7, 4, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (8, 4, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (9, 4, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (10, 4, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (11, 4, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (12, 4, 10);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (1, 5, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (2, 5, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (3, 5, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (4, 5, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (5, 5, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (6, 5, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (7, 5, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (8, 5, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (9, 5, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (10, 5, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (11, 5, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (12, 5, 10);


/*The second group*/
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (13, 6, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (14, 6, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (15, 6, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (16, 6, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (17, 6, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (18, 6, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (19, 6, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (20, 6, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (21, 6, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (22, 6, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (23, 6, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (24, 6, 10);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (13, 7, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (14, 7, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (15, 7, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (16, 7, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (17, 7, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (18, 7, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (19, 7, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (20, 7, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (21, 7, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (22, 7, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (23, 7, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (24, 7, 10);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (13, 8, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (14, 8, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (15, 8, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (16, 8, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (17, 8, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (18, 8, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (19, 8, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (20, 8, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (21, 8, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (22, 8, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (23, 8, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (24, 8, 10);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (13, 9, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (14, 9, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (15, 9, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (16, 9, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (17, 9, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (18, 9, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (19, 9, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (20, 9, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (21, 9, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (22, 9, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (23, 9, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (24, 9, 7);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (13, 10, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (14, 10, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (15, 10, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (16, 10, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (17, 10, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (18, 10, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (19, 10, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (20, 10, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (21, 10, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (22, 10, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (23, 10, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (24, 10, 10);

/*The third group*/
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (25, 11, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (26, 11, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (27, 11, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (28, 11, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (29, 11, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (30, 11, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (31, 11, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (32, 11, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (33, 11, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (34, 11, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (35, 11, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (36, 11, 10);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (25, 12, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (26, 12, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (27, 12, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (28, 12, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (29, 12, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (30, 12, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (31, 12, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (32, 12, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (33, 12, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (34, 12, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (35, 12, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (36, 12, 10);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (25, 13, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (26, 13, 6);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (27, 13, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (28, 13, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (29, 13, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (30, 13, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (31, 13, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (32, 13, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (33, 13, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (34, 13, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (35, 13, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (36, 13, 6);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (25, 14, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (26, 14, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (27, 14, 5);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (28, 14, 7);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (29, 14, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (30, 14, 6);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (31, 14, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (32, 14, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (33, 14, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (34, 14, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (35, 14, 2);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (36, 14, 6);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (25, 15, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (26, 15, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (27, 15, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (28, 15, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (29, 15, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (30, 15, 9);

INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (31, 15, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (32, 15, 10);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (33, 15, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (34, 15, 8);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (35, 15, 9);
INSERT INTO Grades(ExamId, StudentId, Grade)
VALUES (36, 15, 8);