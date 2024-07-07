--create database Flex_trainer
CREATE TABLE account (
    username VARCHAR(255) PRIMARY KEY,
    account_type VARCHAR(10),
    email VARCHAR(255),
    password VARCHAR(255)
);

CREATE TABLE userr (
    id INT PRIMARY KEY,
    firstname VARCHAR(255),
    lastname VARCHAR(255),
    username VARCHAR(255),
    gender VARCHAR(6),
	FOREIGN KEY (username) REFERENCES account(username)
);


CREATE TABLE owner (
    id INT PRIMARY KEY
);

CREATE TABLE admin (
    id INT PRIMARY KEY
);
CREATE TABLE trainer (
    id INT PRIMARY KEY,
    rating DECIMAL(5, 2),
    experience INT
);
CREATE TABLE member (
    id INT PRIMARY KEY,
    membership_status VARCHAR(20),
    membership_type VARCHAR(20)
);

CREATE TABLE gym (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    location VARCHAR(255),
    owner_id INT,
	FOREIGN KEY (owner_id) REFERENCES owner(id)

);
CREATE TABLE reports (
    id INT PRIMARY KEY,
    gym_id INT,
	report_date date,
    customer_satisfaction DECIMAL(5, 2),
    class_attendance_rates DECIMAL(5, 2),
    financial_performance DECIMAL(10, 2),
    membership_growth INT,
	FOREIGN KEY (gym_id) REFERENCES gym(id)
);

CREATE TABLE Training_sessions(
	status VARCHAR(20),
	timing date,
	id INT PRIMARY KEY,
	member_id INt,
	trainer_id INT,
	gym_id INT,
	FOREIGN KEY (member_id) REFERENCES member(id),
	FOREIGN KEY (trainer_id) REFERENCES trainer(id),
	FOREIGN KEY (gym_id) REFERENCES gym(id)

)

Create Table gym_assign_to_trainer(
	id INT PRIMARY KEY,
	gym_id int,
	FOREIGN KEY (gym_id) REFERENCES gym(id)
)

CREATE TABLE feedback(
	id INT PRIMARY KEY,	
	member_id int,
	trainer_id int,
	gym_id int,
	rating int,
	FOREIGN KEY (member_id) REFERENCES member(id),
	FOREIGN KEY (trainer_id) REFERENCES trainer(id),
	FOREIGN KEY (gym_id) REFERENCES gym(id)
	
)

CREATE TABLE Plann(
	name varchar(30),
	id INT PRIMARY KEY,
	creator_type varchar(20),
	creator_id int,
	status varchar(20),
	FOREIGN KEY (creator_id) REFERENCES userr(id)
)

CREATE TABLE diet_plan(
	nutrition varchar(255),
	type varchar(255),
	goal varchar(255),
	plan_id int,
	FOREIGN KEY (plan_id) REFERENCES plann(id)
)

CREATE TABLE meals(
	id INT PRIMARY KEY,
	allergents varchar(255),
	nutrional_val varchar(255),
	plan_id int,
	FOREIGN KEY (plan_id) REFERENCES plann(id)
)

CREATE TABLE workout_plan(
	goal varchar(255),
	experience_lvl varchar(20),
	schedule varchar(20),
	plan_id int,
	FOREIGN KEY (plan_id) REFERENCES plann(id)
)

CREATE TABLE exercise(
	id INT PRIMARY KEY,
	reps INT,
	sets INT,
	target_muscles varchar(100),
	routine varchar(50),
	machine varchar(50),
	plan_id int,
	FOREIGN KEY (plan_id) REFERENCES plann(id)
)



-- Inserting data into the account table
INSERT INTO account  VALUES ('mmuhriz23', 'member', 'muhriz25@gmail.com', 'muhriz987');
INSERT INTO account  VALUES ('hamdan3390', 'member', 'hamdan45@hotmail.com', 'train_hard002');
INSERT INTO account  VALUES ('mujtaba6565', 'member', 'mmujtaba@gmail.com', 'tap321');
INSERT INTO account  VALUES ('kuroashi983', 'member', 'maria21@yahoo.com', 'seeya232');
INSERT INTO account  VALUES ('mario04', 'member', 'mmujtaba@gmail.com', 'back_to_the_future321');


-- Inserting data into the userr table
INSERT INTO userr  VALUES (1, 'Muhriz', 'Ashfaque', 'mmuhriz23', 'male');
INSERT INTO userr  VALUES (2, 'Hamdan', 'Sajid', 'hamdan3390', 'male');
INSERT INTO userr  VALUES (3, 'Muhammad', 'Mujtaba', 'mujtaba6565', 'male');
INSERT INTO userr  VALUES (4, 'Maria', 'Naeem', 'kuroashi983', 'female');
INSERT INTO userr  VALUES (5, 'Sohaib', 'Danish', 'mario04', 'male');



-- Inserting data into the Plann table
INSERT INTO Plann  VALUES ('Plan 1', 1, 'member', 1, 'public');
INSERT INTO Plann  VALUES ('Plan 2', 2, 'member', 2, 'private');
INSERT INTO Plann  VALUES ('Plan 3', 3, 'member', 3, 'public');
INSERT INTO Plann  VALUES ('Plan 4', 4, 'member', 1, 'private');
INSERT INTO Plann  VALUES ('Plan 5', 5, 'member', 2, 'public');

-- Inserting data into the workout_plan table (two for each plan)
INSERT INTO workout_plan  VALUES ('Build muscle', 'Intermediate', '3 days/week', 1);
INSERT INTO workout_plan  VALUES ('Lose weight', 'Beginner', '5 days/week', 1);
INSERT INTO workout_plan  VALUES ('Improve endurance', 'Advanced', '4 days/week', 2);
INSERT INTO workout_plan  VALUES ('Gain strength', 'Intermediate', '3 days/week', 2);
INSERT INTO workout_plan  VALUES ('Build muscle', 'Beginner', '5 days/week', 3);
INSERT INTO workout_plan  VALUES ('Lose weight', 'Advanced', '4 days/week', 3);
INSERT INTO workout_plan  VALUES ('Improve endurance', 'Intermediate', '3 days/week', 4);
INSERT INTO workout_plan  VALUES ('Gain strength', 'Beginner', '5 days/week', 4);
INSERT INTO workout_plan  VALUES ('Build muscle', 'Advanced', '4 days/week', 5);
INSERT INTO workout_plan  VALUES ('Lose weight', 'Intermediate', '3 days/week', 5);

-- Inserting data into the exercise table (two for each plan)
INSERT INTO exercise  VALUES (1, 12, 3, 'Chest, Triceps', 'Pushups', 'None', 1);
INSERT INTO exercise  VALUES (2, 10, 3, 'Back, Biceps', 'Pull-ups', 'Pull-up bar', 1);
INSERT INTO exercise  VALUES (3, 15, 4, 'Legs', 'Squats', 'Barbell', 2);
INSERT INTO exercise  VALUES (4, 12, 3, 'Core', 'Plank', 'None', 2);
INSERT INTO exercise  VALUES (5, 20, 4, 'Chest, Triceps', 'Pushups', 'None', 3);
INSERT INTO exercise  VALUES (6, 12, 3, 'Back, Biceps', 'Pull-ups', 'Pull-up bar', 3);
INSERT INTO exercise  VALUES (7, 10, 3, 'Legs', 'Squats', 'Barbell', 4);
INSERT INTO exercise  VALUES (8, 15, 4, 'Core', 'Plank', 'None', 4);
INSERT INTO exercise  VALUES (9, 12, 3, 'Chest, Triceps', 'Pushups', 'None', 5);
INSERT INTO exercise  VALUES (10, 20, 4, 'Back, Biceps', 'Pull-ups', 'Pull-up bar', 5);

INSERT INTO diet_plan (nutrition, type, goal, plan_id) VALUES
('High Protein', 'Keto', 'Muscle Gain', 1),
('Balanced', 'Vegetarian', 'Weight Loss', 2),
('Low Carb', 'Paleo', 'General Fitness', 3),
('High Fiber', 'Mediterranean', 'Endurance Training', 4),
('Low Fat', 'Vegan', 'Bodybuilding', 5);


SELECT *
From workout_plan

SELECT goal AS 'Goal', nutrition AS 'Nutrition', type AS 'Type'
FROM diet_plan
