-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 12, 2021 at 12:23 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel`
--

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `addFBill`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addFBill` (IN `bid` INT(8), IN `fid` VARCHAR(5), IN `q` INT(4), IN `today` DATETIME)  BEGIN
	INSERT INTO food_bill(FoodBillID,FoodID,Quantity, PDate) VALUES (bid,fid,q,today);
END$$

DROP PROCEDURE IF EXISTS `addNewEmp`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addNewEmp` (IN `id` VARCHAR(8), IN `fname` VARCHAR(100), IN `fullname` VARCHAR(500), IN `pos` VARCHAR(8), IN `nic` VARCHAR(15), IN `gen` CHAR(1), IN `t1` VARCHAR(18), IN `t2` VARCHAR(18), IN `addr` VARCHAR(500), IN `pw` VARCHAR(10), IN `email` VARCHAR(200), IN `joinD` DATE, IN `p1` VARCHAR(255), IN `p2` VARCHAR(255))  BEGIN

	INSERT INTO staff (EmpID, EmpFName, EmpFullName, EmpPositionID, EmpNIC, Gender, TP1, TP2, EmpAddress, EmpPassword, EmpEmail, JoiningDate,Photo,CopyNic) VALUES (id, fname, fullname, pos, nic, gen, t1, t2, addr, pw, email, joinD,p1,p2);

END$$

DROP PROCEDURE IF EXISTS `addNewFood`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addNewFood` (IN `name` VARCHAR(30), IN `price` INT(6), IN `cat` VARCHAR(6))  BEGIN
	INSERT INTO food(FoodName,FoodPrice,FoodCategoryID) VALUES (name,price,cat);
END$$

DROP PROCEDURE IF EXISTS `addNewGuest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addNewGuest` (IN `IDCat` CHAR(5), IN `NICNo` VARCHAR(15), IN `addfName` VARCHAR(100), IN `addfullName` VARCHAR(500), IN `Gen` CHAR(1), IN `addEmail` VARCHAR(200), IN `guestAddr` VARCHAR(500))  BEGIN
INSERT INTO guest_details(IDCategory,IDNumber,FName,FullName,Gender,Email,GuestAddress) VALUES (IDCat,NICNO,addfName,addfullName,gen,addEmail,guestAddr);

END$$

DROP PROCEDURE IF EXISTS `addNewPosition`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addNewPosition` (IN `id` VARCHAR(8), IN `name` VARCHAR(50), IN `sal` INT(7))  BEGIN
	INSERT INTO employee_position(PositionID,Position,Salary) VALUES (id,name,sal);
END$$

DROP PROCEDURE IF EXISTS `addNewTP`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addNewTP` (IN `id` VARCHAR(15), IN `tp` VARCHAR(18))  BEGIN
	INSERT INTO guest_tp (IDNum, GuestTP) VALUES (id, tp);
    
END$$

DROP PROCEDURE IF EXISTS `addOtherGuest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addOtherGuest` (IN `GID` INT(8), IN `OGID` VARCHAR(15), IN `OGName` VARCHAR(200))  BEGIN	
    INSERT INTO other_guest_details (GuestID,MemberNIC,MemberName) VALUES(GID,OGID,OGName);

END$$

DROP PROCEDURE IF EXISTS `addReservation`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addReservation` (IN `GID` INT(8), IN `ID` VARCHAR(15), IN `StartD1` DATETIME)  BEGIN	
    INSERT INTO reservation (GuestID,IDNumber,StartDate) VALUES (GID,ID,StartD1);
    
End$$

DROP PROCEDURE IF EXISTS `addRoomBooking`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addRoomBooking` (IN `Guest` SMALLINT(8), IN `Room` TINYINT(4), IN `StartD` DATETIME, IN `EndD` DATETIME)  BEGIN	
    INSERT INTO Room_booking (GuestID,RoomID,StartDate,EndDate) VALUES (Guest,Room,StartD,EndD);
    
End$$

DROP PROCEDURE IF EXISTS `addRoomBooking2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addRoomBooking2` (IN `Guest` INT(8), IN `Room` TINYINT(4), IN `StartD` DATETIME)  BEGIN	
    INSERT INTO Room_booking (GuestID,RoomID,StartDate) VALUES (Guest,Room,StartD);
    
End$$

DROP PROCEDURE IF EXISTS `addServiceBooking`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addServiceBooking` (IN `GID` INT(8), IN `RID` TINYINT(4), IN `SID` SMALLINT(6), IN `SDate` DATETIME, IN `EDate` DATETIME)  BEGIN
INSERT INTO service_booking(GuestID,RoomID,ServiceID,StartDate,EndDate) VALUES (GID,RID,SID,SDate,EDate);

END$$

DROP PROCEDURE IF EXISTS `addServiceBooking2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addServiceBooking2` (IN `GID` INT(8), IN `RID` TINYINT(4), IN `SID` SMALLINT(6), IN `SDate` DATETIME)  BEGIN
INSERT INTO service_booking(GuestID,RoomID,ServiceID,StartDate) VALUES (GID,RID,SID,SDate);

END$$

DROP PROCEDURE IF EXISTS `delGuest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delGuest` (IN `id` VARCHAR(15))  BEGIN

	DELETE FROM guest_details WHERE IDNumber=id;

END$$

DROP PROCEDURE IF EXISTS `getAllFacilities`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getAllFacilities` ()  BEGIN
	select ServicesID as 'Facility No', 		ServiceType as 'Facility', servicePrice as 	'Price' from services;
END$$

DROP PROCEDURE IF EXISTS `getAllFood`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getAllFood` ()  BEGIN
	select FoodID as 'Food ID', 		FoodName as 'Name', FoodPrice as 	'Price' from food;
END$$

DROP PROCEDURE IF EXISTS `getAllRooms`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getAllRooms` ()  BEGIN

	SELECT room.RoomID AS 'No' , room_catergory.RoomCatergoryType AS 'Room Type' FROM room INNER JOIN room_catergory ON room.RoomCategoryID=room_catergory.RoomCatergoryID ORDER BY room.RoomID ASC;
    
END$$

DROP PROCEDURE IF EXISTS `getAllStaff`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getAllStaff` ()  BEGIN
	select staff.EmpID as 'Staff ID', staff.EmpFullName as 'Name', employee_position.Position as 'Position' from staff INNER JOIN employee_position ON staff.EmpPositionID=employee_position.PositionID;
END$$

DROP PROCEDURE IF EXISTS `getBookedRooms`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getBookedRooms` (IN `today` DATETIME)  BEGIN

	SELECT room.RoomID AS 'No', guest_details.IDNumber AS 'ID', guest_details.FName As 'Name', room_booking.StartDate AS 'Arrival',room_booking.EndDate AS 'Depature' FROM room,room_booking, reservation, guest_details WHERE (guest_details.IDNumber = reservation.IDNumber AND room_booking.GuestID=reservation.GuestID AND room.RoomID=room_booking.RoomID ) AND ((room_booking.StartDate <= today and room_booking.EndDate >= today) OR (room_booking.StartDate <= today AND room_booking.EndDate IS NULL)OR (room_booking.StartDate >= today AND room_booking.EndDate >= today)OR (room_booking.StartDate >= today AND room_booking.EndDate IS NULL)) ORDER BY room.RoomID;
    
END$$

DROP PROCEDURE IF EXISTS `getDdate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getDdate` (IN `room` TINYINT(4), IN `date` DATETIME)  SELECT DISTINCT DATE_FORMAT(EndDate,'%Y-%m-%d %T') AS 'End Date' FROM room_booking WHERE RoomID=room AND StartDate=date$$

DROP PROCEDURE IF EXISTS `getFoodPayment`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getFoodPayment` (IN `rid` TINYINT(3), IN `sdate` DATETIME, IN `edate` DATETIME)  SELECT food_order.FoodID as 'Food ID',Quantity, (food_order.Quantity*food.FoodPrice) AS 'Amount', DATE_FORMAT(food_order.DateTime, '%Y-%m-%d %T') AS 'Date' FROM food_order INNER JOIN food ON food_order.FoodID=food.FoodID WHERE food_order.RoomID = rid AND sdate <= food_order.DateTime <= edate$$

DROP PROCEDURE IF EXISTS `getFreeRooms`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getFreeRooms` (IN `today` DATETIME)  BEGIN

	SELECT room.RoomID AS 'No' , room_catergory.RoomCatergoryType AS 'Room Type' FROM room INNER JOIN room_catergory ON room.RoomCategoryID=room_catergory.RoomCatergoryID WHERE room.RoomID NOT IN (SELECT DISTINCT RoomId FROM room_booking WHERE (today BETWEEN StartDate AND EndDate) OR (StartDate <= today AND EndDate IS NULL)) ORDER BY room.RoomID ASC; 
    
END$$

DROP PROCEDURE IF EXISTS `getFreeRooms2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getFreeRooms2` (IN `today` DATETIME)  BEGIN

	SELECT * FROM room WHERE RoomID NOT IN (SELECT room_booking.RoomID FROM room_booking WHERE ((room_booking.StartDate <= today and room_booking.EndDate >= today) OR (room_booking.StartDate <= today AND room_booking.EndDate IS NULL)));
    
END$$

DROP PROCEDURE IF EXISTS `getGuestDetailsByDate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getGuestDetailsByDate` (IN `date` DATETIME)  BEGIN

	SELECT DATE_FORMAT(room_booking.StartDate,'%Y-%m-%d %T') AS 'Date', reservation.IDNumber As 'NIC or Passport No', room_booking.RoomID AS 'Room No' FROM reservation INNER JOIN room_booking ON room_booking.GuestID=reservation.GuestID WHERE (date>=room_booking.StartDate AND date<=room_booking.EndDate) OR (room_booking.StartDate<=date AND room_booking.EndDate IS NULL);

End$$

DROP PROCEDURE IF EXISTS `getGuestDetailsByID`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getGuestDetailsByID` (IN `NIC` VARCHAR(15))  BEGIN

	SELECT DATE_FORMAT(room_booking.StartDate,'%Y-%m-%d %T') AS 'Date', reservation.IDNumber As 'NIC or Passport No', room_booking.RoomID AS 'Room No' FROM reservation INNER JOIN room_booking ON room_booking.GuestID=reservation.GuestID WHERE reservation.IDNumber=NIC;

End$$

DROP PROCEDURE IF EXISTS `getGuestID`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getGuestID` (IN `NIC` VARCHAR(15), IN `today` DATETIME)  BEGIN

	SELECT reservation.GuestID FROM reservation INNER JOIN room_booking ON room_booking.GuestID=reservation.GuestID WHERE reservation.IDNumber=NIC AND ((room_booking.StartDate<=today AND room_booking.EndDate>=today) OR(room_booking.StartDate<=today AND room_booking.EndDate IS NULL) OR(room_booking.StartDate>today));
    
END$$

DROP PROCEDURE IF EXISTS `getID`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getID` ()  BEGIN
	
    SELECT IDNumber FROM guest_details;
    
END$$

DROP PROCEDURE IF EXISTS `getOrderDetails`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrderDetails` (IN `Oid` INT(8))  SELECT  food_order.RoomID AS 'Room No',food.FoodName AS "Food Item", food_order.Quantity,(food.FoodPrice*food_order.Quantity) AS 'Price' FROM food INNER JOIN food_order ON food.FoodID=food_order.FoodID WHERE OrderID = Oid$$

DROP PROCEDURE IF EXISTS `getReservationPayment`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getReservationPayment` (IN `rid` TINYINT(4), IN `sdate` DATETIME, IN `edate` DATETIME)  SELECT (DATEDIFF(edate, sdate)*room_catergory.RoomPrice) AS 'Amount' FROM room INNER JOIN room_booking ON room.RoomID=room_booking.RoomID INNER JOIN room_catergory ON(room.RoomCategoryID=room_catergory.RoomCatergoryID) WHERE room_booking.RoomID=rid AND room_booking.StartDate=sdate and room_booking.EndDate=edate$$

DROP PROCEDURE IF EXISTS `getReservationPayment2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getReservationPayment2` (IN `rid` TINYINT(4), IN `sdate` DATETIME, IN `edate` DATETIME)  SELECT (1*room_catergory.RoomPrice) AS 'Amount' FROM room INNER JOIN room_booking ON room.RoomID=room_booking.RoomID INNER JOIN room_catergory ON(room.RoomCategoryID=room_catergory.RoomCatergoryID) WHERE room_booking.RoomID=rid AND room_booking.StartDate=sdate and room_booking.EndDate=edate$$

DROP PROCEDURE IF EXISTS `getRoomCategorybyRoomID`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getRoomCategorybyRoomID` (IN `room` TINYINT(4))  SELECT room_catergory.RoomCatergoryType FROM room_catergory INNER JOIN room ON room_catergory.RoomCatergoryID=room.RoomCategoryID WHERE room.RoomID=room$$

DROP PROCEDURE IF EXISTS `getRoomCount`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getRoomCount` (IN `today` DATETIME, IN `RoomType` CHAR(3))  BEGIN

	SELECT COUNT(room.RoomID) AS 'No' FROM room INNER JOIN room_catergory ON room.RoomCategoryID=room_catergory.RoomCatergoryID WHERE room.RoomID NOT IN (SELECT DISTINCT RoomId FROM room_booking WHERE (today <= StartDate AND EndDate>=today) OR (StartDate <= today AND EndDate IS NULL)) AND room_catergory.RoomCatergoryID = RoomType ORDER BY room.RoomID ASC; 
    
END$$

DROP PROCEDURE IF EXISTS `getRoomsForPayment`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getRoomsForPayment` (IN `NIC` VARCHAR(15), IN `today` DATETIME)  BEGIN

	SELECT DATE_FORMAT(room_booking.StartDate,'%Y-%m-%d %T') AS 'Arrival', reservation.IDNumber As 'ID No', room_booking.RoomID AS 'Room No' FROM reservation INNER JOIN room_booking ON room_booking.GuestID=reservation.GuestID WHERE reservation.IDNumber=NIC AND ((room_booking.StartDate<=today AND room_booking.EndDate>=today) OR(room_booking.StartDate<=today AND room_booking.EndDate IS NULL));

End$$

DROP PROCEDURE IF EXISTS `getRoomsPaymentByDate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getRoomsPaymentByDate` (IN `sdate` DATETIME, IN `eDate` DATETIME)  BEGIN

	SELECT DATE_FORMAT(room_booking.StartDate,'%Y-%m-%d %T') AS 'Arrival', reservation.IDNumber As 'ID No', room_booking.RoomID AS 'Room No' FROM reservation INNER JOIN room_booking ON room_booking.GuestID=reservation.GuestID WHERE ((room_booking.StartDate>=sdate AND room_booking.EndDate<=edate) OR(room_booking.StartDate>=sdate AND room_booking.EndDate IS NULL));

End$$

DROP PROCEDURE IF EXISTS `getSelectedFacility`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getSelectedFacility` (IN `service` VARCHAR(30))  BEGIN
	select ServicesID as 'Facility No', ServiceType as 		'Facility', ServicePrice as 'Price' from services where ServiceType like service;
END$$

DROP PROCEDURE IF EXISTS `getSelectedFood`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getSelectedFood` (IN `FoodCategory` VARCHAR(6))  select FoodID as 'Food ID', FoodName as 'Name', FoodPrice as 'Price' from food where FoodCategoryID LIKE FoodCategory$$

DROP PROCEDURE IF EXISTS `getSelectedFoodbyName`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getSelectedFoodbyName` (IN `food` VARCHAR(30))  NO SQL
BEGIN
	select FoodID as 'Food ID', FoodName as 		'Name', FoodPrice as 'Price' from food 			where FoodName like food OR FoodID LIKE food;
END$$

DROP PROCEDURE IF EXISTS `getSelectedID`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getSelectedID` (IN `id` VARCHAR(15))  BEGIN
	
    SELECT IDNumber FROM guest_details WHERE IDNumber LIKE id;
    
END$$

DROP PROCEDURE IF EXISTS `getSelectedPosition`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getSelectedPosition` (IN `pos` VARCHAR(50))  BEGIN
	select * from employee_position where Position like pos OR PositionID like pos;

END$$

DROP PROCEDURE IF EXISTS `getServicePayment`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getServicePayment` (IN `rid` TINYINT(4), IN `sdate` DATETIME, IN `edate` DATETIME)  SELECT services.ServiceType as 'Facility',  DATE_FORMAT(service_booking.StartDate, '%Y-%m-%d %T') AS 'Start Date',DATE_FORMAT(service_booking.EndDate, '%Y-%m-%d %T') AS 'End Date',(DATEDIFF(service_booking.EndDate, service_booking.StartDate)*services.ServicePrice) AS 'Amount' FROM services INNER JOIN service_booking ON service_booking.ServiceID=services.ServicesID WHERE service_booking.RoomID = rid AND (sdate<= service_booking.StartDate AND service_booking.EndDate >= edate) OR (sdate<= service_booking.StartDate AND service_booking.StartDate is NULL)$$

DROP PROCEDURE IF EXISTS `getStaffbyName`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getStaffbyName` (IN `staff` VARCHAR(500))  BEGIN
	select staff.EmpID as 'Staff ID', staff.EmpFullName as 'Name', employee_position.Position as 'Position' from staff INNER JOIN employee_position ON staff.EmpPositionID=employee_position.PositionID WHERE staff.EmpFullName LIKE staff or staff.EmpID LIKE staff;
END$$

DROP PROCEDURE IF EXISTS `getTPbyId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getTPbyId` (IN `id` VARCHAR(15))  NO SQL
BEGIN

SELECT guest_tp.GuestTP FROM guest_tp INNER JOIN guest_details ON guest_tp.IDNum=guest_details.IDNumber WHERE guest_details.IDNumber = id;

END$$

DROP PROCEDURE IF EXISTS `getUserPw`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getUserPw` (IN `sid` VARCHAR(8))  SELECT EmpPassword FROM staff WHERE EmpID=sid$$

DROP PROCEDURE IF EXISTS `getValuesById`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getValuesById` (IN `user_id` VARCHAR(15), OUT `F_Name` VARCHAR(100), OUT `Full_Name` VARCHAR(500), OUT `Gen` CHAR(1), OUT `Email` VARCHAR(200), OUT `Addr` VARCHAR(500), OUT `ID_Cat` CHAR(5))  BEGIN
	SELECT FName INTO F_Name FROM guest_details WHERE IDNumber = user_id;
    
    SELECT FullName INTO Full_Name FROM guest_details WHERE IDNumber = user_id;
    
    SELECT Gender INTO Gen FROM guest_details WHERE IDNumber = user_id;
    
    SELECT Email INTO Email FROM guest_details WHERE IDNumber = user_id;
    
    SELECT GuestAddress INTO Addr FROM guest_details WHERE IDNumber = user_id;
    
    SELECT IDCategory INTO ID_Cat FROM guest_details WHERE IDNumber = user_id;
    
    
END$$

DROP PROCEDURE IF EXISTS `UpdateFacility`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateFacility` (IN `fname` VARCHAR(30), IN `price` SMALLINT(6), IN `fid` SMALLINT(6))  BEGIN

	UPDATE services
SET ServiceType = fname, ServicePrice= price 
WHERE ServicesID = fid;

END$$

DROP PROCEDURE IF EXISTS `UpdateFood`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateFood` (IN `fname` VARCHAR(30), IN `price` INT(6), IN `catID` VARCHAR(6), IN `fid` SMALLINT(5))  BEGIN

	UPDATE food
SET FoodName = fname, FoodPrice= price, FoodCategoryID = catID
WHERE FoodID = fid;

END$$

DROP PROCEDURE IF EXISTS `updateGuestDetails`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updateGuestDetails` (IN `newID` VARCHAR(15), IN `IDCat` CHAR(5), IN `fiName` VARCHAR(100), IN `fuName` VARCHAR(500), IN `gen` CHAR(1), IN `mail` VARCHAR(200), IN `oldID` VARCHAR(15), IN `address` VARCHAR(500))  UPDATE guest_details
SET IDNumber = newID, IDCategory= IDcat, Fname= fiName, FullName=fuName, Gender=gen, Email=mail, GuestAddress=address
WHERE IDNumber = oldID$$

DROP PROCEDURE IF EXISTS `UpdatePosition`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePosition` (IN `PID` VARCHAR(8), IN `pos` VARCHAR(50), IN `sal` INT(7), IN `PIDOld` VARCHAR(8))  BEGIN

	UPDATE employee_position
SET PositionID = PID, Position= pos 
,Salary = sal WHERE PositionID=PIDOld;

END$$

DROP PROCEDURE IF EXISTS `UpdatePw`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePw` (IN `pw` VARCHAR(10), IN `eid` VARCHAR(8))  UPDATE staff SET EmpPassword = pw WHERE EmpID = eid$$

DROP PROCEDURE IF EXISTS `UpdateStaff`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateStaff` (IN `NeID` VARCHAR(8), IN `fname` VARCHAR(100), IN `fullname` VARCHAR(500), IN `posID` VARCHAR(8), IN `gen` CHAR(1), IN `t1` VARCHAR(18), IN `t2` VARCHAR(18), IN `address` VARCHAR(500), IN `mail` VARCHAR(200), IN `oeID` VARCHAR(8))  BEGIN
UPDATE staff
SET EmpID=NeID, EmpFName = fname, EmpFullName= fullname, EmpPositionId = posId,Gender=gen, TP1=t1, TP2=t2 , EmpAddress=address, EmpEmail=mail
WHERE EmpID = OeID;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `cleanings`
--

DROP TABLE IF EXISTS `cleanings`;
CREATE TABLE IF NOT EXISTS `cleanings` (
  `EmployeeID` varchar(8) NOT NULL,
  `CleaningDate&Time` date NOT NULL,
  `CleaningShift` int(3) NOT NULL,
  `RoomID` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employee_position`
--

DROP TABLE IF EXISTS `employee_position`;
CREATE TABLE IF NOT EXISTS `employee_position` (
  `PositionID` varchar(8) NOT NULL,
  `Position` varchar(50) NOT NULL,
  `Salary` int(7) NOT NULL,
  PRIMARY KEY (`PositionID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_position`
--

INSERT INTO `employee_position` (`PositionID`, `Position`, `Salary`) VALUES
('ADM', 'Admin/Management', 85000),
('CHF', 'Chef', 55000),
('CLN', 'Cleaning Staff', 30000),
('CSH', 'Restaurant Cashier', 50000),
('RCP', 'Receptionist', 60000),
('SCR', 'Security Officer', 22000),
('WTR', 'Waiter', 30000);

-- --------------------------------------------------------

--
-- Table structure for table `employee_salary`
--

DROP TABLE IF EXISTS `employee_salary`;
CREATE TABLE IF NOT EXISTS `employee_salary` (
  `EmployeeID` varchar(8) NOT NULL,
  `Bonus` int(6) DEFAULT NULL,
  `Total` int(7) NOT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

DROP TABLE IF EXISTS `food`;
CREATE TABLE IF NOT EXISTS `food` (
  `FoodID` smallint(5) NOT NULL AUTO_INCREMENT,
  `FoodName` varchar(30) NOT NULL,
  `FoodPrice` int(6) NOT NULL,
  `FoodCategoryID` varchar(6) NOT NULL,
  PRIMARY KEY (`FoodID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`FoodID`, `FoodName`, `FoodPrice`, `FoodCategoryID`) VALUES
(1, 'Chicken Fried Rice(S)', 350, '123'),
(2, 'Chicken Fried Rice(L)', 500, '123'),
(3, 'Chicken Kottu(S)', 450, '23'),
(4, 'Chicken Kottu(L)', 600, '23'),
(5, 'Beef Kottu(S)', 500, '23'),
(6, 'Beef Kottu(L)', 700, '23'),
(7, 'Sea Food Special Buriyani(L)', 800, '3'),
(8, 'Sea Food Special Pasta(L)', 750, '3'),
(9, 'Broccoli cheddar baked potato', 1250, '123'),
(10, 'Chicken or Tuna Roti Wraps', 800, '12'),
(11, 'Seafood Spaghetti', 500, '23'),
(12, 'Watalappan', 200, '5'),
(13, 'Creme Caramel', 250, '5'),
(14, 'Ice Cream Sundae Vanila', 300, '5'),
(15, 'Ice Cream Sundae Chocolate', 350, '5'),
(16, 'Mango Lassie', 300, '4'),
(17, 'Papaya Juice', 200, '4'),
(18, 'Mango Juice', 200, '4'),
(19, 'Pineapple Juice', 250, '4'),
(20, 'Lime Juice', 300, '4'),
(21, 'Orange Juice', 400, '4'),
(22, 'Sweet Lassie', 300, '4'),
(23, 'Salty Lassie', 250, '4'),
(24, 'Grilled Beef Cheeks', 1800, '3'),
(25, 'Nigiri Sushi', 1000, '3'),
(26, 'Signature Rice Paper Rolls', 950, '23'),
(27, 'Potato Wedges', 850, '123'),
(28, 'Pasta Napolitano', 890, '123'),
(29, 'French Fries', 300, '23'),
(30, 'Egg Hoppers and Seeni Sambol', 250, '1'),
(31, 'String Hoppers', 150, '1'),
(32, 'French Toast', 400, '1'),
(33, 'Vegetable Tempura', 250, '123'),
(34, 'Grilled Prawns', 700, '3'),
(35, 'Chicken Spring Rolls Large', 350, '23'),
(36, 'Chicken Spring Rolls Small', 250, '23'),
(37, 'Ham and Cheese', 530, '12'),
(38, 'Beef Burger with Chips', 680, '23'),
(39, 'Cream of Prawn', 650, '23'),
(40, 'Seafood Tom Yam', 680, '23'),
(41, 'Spaghetti Bolognese', 970, '3'),
(42, 'Classic Carbonara', 450, '3'),
(43, 'Chilli Crabs Singapore Style', 650, '12'),
(44, 'Chilli Crabs Singapore Style', 650, '12'),
(45, 'Fried Calamari', 460, '12'),
(46, 'Chargrilled Tuna', 640, '1'),
(47, 'Jumbo Prawns Thermidor', 540, '12'),
(48, 'Fish Fillet with Peanut Butter', 970, '1'),
(49, 'Oven Roasted Chicken Small', 680, '3'),
(50, 'Garlic Honey Chicken Small', 560, '3'),
(51, 'Garlic Honey Chicken Large', 950, '3'),
(52, 'Oven Roasted Chicken Large', 1320, '3'),
(53, 'Garlic Bread', 160, '1'),
(54, 'Cheese Corn Blast', 425, '6'),
(55, 'Vegetable Patty', 200, '6');

-- --------------------------------------------------------

--
-- Table structure for table `food_bill`
--

DROP TABLE IF EXISTS `food_bill`;
CREATE TABLE IF NOT EXISTS `food_bill` (
  `FoodBillID` int(8) NOT NULL,
  `FoodID` varchar(5) NOT NULL,
  `Quantity` int(4) NOT NULL,
  `PDate` datetime NOT NULL,
  PRIMARY KEY (`FoodBillID`,`FoodID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `food_bill`
--

INSERT INTO `food_bill` (`FoodBillID`, `FoodID`, `Quantity`, `PDate`) VALUES
(0, '0', 0, '2021-08-10 21:24:33'),
(1, '12', 4, '2021-08-10 00:00:00'),
(1, '13', 1, '2021-08-10 00:00:00'),
(1, '3', 1, '2021-08-10 00:00:00'),
(1, '7', 2, '2021-08-10 00:00:00'),
(2, '11', 1, '2021-08-10 00:00:00'),
(2, '12', 2, '2021-08-10 00:00:00'),
(2, '3', 1, '2021-08-10 00:00:00'),
(2, '9', 4, '2021-08-10 00:00:00'),
(3, '10', 1, '2021-08-10 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `food_category`
--

DROP TABLE IF EXISTS `food_category`;
CREATE TABLE IF NOT EXISTS `food_category` (
  `FoodCategoryID` varchar(6) NOT NULL,
  `FoodCategoryName` varchar(30) NOT NULL,
  PRIMARY KEY (`FoodCategoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `food_category`
--

INSERT INTO `food_category` (`FoodCategoryID`, `FoodCategoryName`) VALUES
('1', 'Breakfast'),
('12', 'Breakfast and Lunch'),
('123', 'Anytime'),
('13', 'Breakfast and Dinner'),
('2', 'Lunch'),
('23', 'Lunch and Dinner'),
('3', 'Dinner'),
('4', 'Beverage'),
('5', 'Desserts'),
('6', 'Snaks');

-- --------------------------------------------------------

--
-- Table structure for table `food_order`
--

DROP TABLE IF EXISTS `food_order`;
CREATE TABLE IF NOT EXISTS `food_order` (
  `OrderID` int(8) NOT NULL AUTO_INCREMENT,
  `FoodID` varchar(5) NOT NULL,
  `Quantity` int(4) NOT NULL,
  `RoomID` tinyint(4) NOT NULL,
  `Status` tinyint(1) NOT NULL,
  `DateTime` datetime NOT NULL,
  PRIMARY KEY (`OrderID`,`FoodID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `food_order`
--

INSERT INTO `food_order` (`OrderID`, `FoodID`, `Quantity`, `RoomID`, `Status`, `DateTime`) VALUES
(4, '0', 0, 0, 1, '2021-08-09 00:27:13'),
(5, '3', 1, 4, 1, '2021-08-09 00:29:00'),
(6, '2', 1, 11, 1, '2021-08-09 02:49:00'),
(7, '10', 1, 1, 1, '2021-08-09 02:49:00'),
(7, '2', 2, 1, 1, '2021-08-09 02:49:00'),
(7, '7', 1, 1, 1, '2021-08-09 02:49:00'),
(8, '8', 1, 1, 1, '2021-08-09 02:50:00'),
(8, '9', 1, 1, 1, '2021-08-09 02:50:00'),
(9, '10', 1, 1, 1, '2021-08-09 02:50:00'),
(10, '5', 2, 1, 1, '2021-08-09 02:50:00'),
(11, '7', 1, 1, 1, '2021-08-09 14:01:00'),
(11, '9', 1, 1, 1, '2021-08-09 14:01:00'),
(12, '1', 1, 1, 1, '2021-08-09 14:25:00'),
(13, '3', 1, 1, 1, '2021-08-10 21:28:00'),
(14, '11', 2, 1, 1, '2021-08-10 21:29:00'),
(14, '4', 1, 1, 1, '2021-08-10 21:29:00'),
(15, '12', 2, 1, 1, '2021-08-10 21:30:00'),
(15, '8', 1, 1, 1, '2021-08-10 21:30:00'),
(16, '3', 1, 1, 1, '2021-08-11 10:29:00'),
(16, '7', 1, 1, 1, '2021-08-11 10:29:00');

-- --------------------------------------------------------

--
-- Table structure for table `guest_details`
--

DROP TABLE IF EXISTS `guest_details`;
CREATE TABLE IF NOT EXISTS `guest_details` (
  `IDNumber` varchar(15) NOT NULL,
  `IDCategory` char(5) NOT NULL,
  `FName` varchar(100) NOT NULL,
  `FullName` varchar(500) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Email` varchar(200) DEFAULT NULL,
  `GuestAddress` varchar(500) NOT NULL,
  PRIMARY KEY (`IDNumber`),
  UNIQUE KEY `IDNumber_2` (`IDNumber`),
  KEY `IDNumber` (`IDNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `guest_details`
--

INSERT INTO `guest_details` (`IDNumber`, `IDCategory`, `FName`, `FullName`, `Gender`, `Email`, `GuestAddress`) VALUES
('197945621452', 'NIC', 'Kalum', 'Kalum Sannasgala', 'M', 'kalum@gmail.com', '43,Maharagama,Colombo'),
('198055465465', 'NIC', 'Hashinthanie', 'Hashinthanie Jayalath', 'F', 'hash@gmail.com', '223/67, Wijayawikrama Rd, Borella'),
('198245654654', 'NIC', 'Mangala', 'Mangala Jayasekara', 'M', '', '34, New Rd, Kirinda'),
('198545678514', 'NIC', 'Gehan', 'Gehan Samarathunga', 'M', 'gehan@gmail.com', '23/5, Udyana Rd, Horana'),
('199456456546', 'NIC', 'Wathsala', 'Wathsala Kumari', 'F', '', '34, Main Street, Colombo 04'),
('199656541321', 'NIC', 'Shihara', 'Shihara Wikramathunga', 'F', 'shihara@gmail.com', '56, Wewalduwa Rd, Kelaniya'),
('199823787343', 'NIC', 'Kamal', 'Kamal Perera de Silva', 'M', 'kamal@gmail.com', '78,Weragampita, Matara'),
('199956455645', 'NIC', 'Sunethya', 'Sunethya Pahandi', 'F', '', '12, Mathugama, Horana'),
('566499559', 'PASS', 'Hyuwan ', 'Hyuwan Shay', 'M', 'shay@gmail.com', '1B/a, Main Street, Bangkok, Thailand'),
('659872234', 'PASS', 'John', 'Christoper John', 'M', 'johnchrist@gmail.com', '23A/2, Green Street, Florida, USA'),
('895645123V', 'NIC', 'Sahan', 'Sahan Wijeweera', 'F', 'sahan@gmail.com', '23,Kadawatha, Kiribathgoda'),
('971238164V', 'NIC', 'Ramesh', 'Ramesh Kavindu ', 'M', 'rame@gmail.com', '333, Galle fort, Colombo'),
('983111912V', 'NIC', 'chamuditha', 'Senanayake', 'M', 'cgamuditha@gmail.com', 'kegalle'),
('984782483V', 'NIC', 'Dilum ', 'Dilum Perera', 'M', '', '75, Walk Street, Gampaha'),
('986389878V', 'NIC', 'Apsara ', 'Apsara Dilshani', 'F', 'apsaraa@gmail.com', '20, Buttala Rd, Monaragala');

-- --------------------------------------------------------

--
-- Table structure for table `guest_tp`
--

DROP TABLE IF EXISTS `guest_tp`;
CREATE TABLE IF NOT EXISTS `guest_tp` (
  `IDNum` varchar(15) NOT NULL,
  `GuestTP` varchar(18) NOT NULL,
  PRIMARY KEY (`IDNum`,`GuestTP`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `guest_tp`
--

INSERT INTO `guest_tp` (`IDNum`, `GuestTP`) VALUES
('197945621452', '(077) 564-5654'),
('198055465465', '(077) 658-4654'),
('198245654654', '(077) 986-5685'),
('198545678514', '(071) 889-8978'),
('199456456546', '(077) 898-7546'),
('199656541321', '(077) 895-6456'),
('199823787343', '(078) 654-6545'),
('199956455645', '(077) 894-5654'),
('566499559', '(+9) 863-564-3651'),
('659872234', '(+9) 654-134-4165'),
('895645123V', '(077) 895-6456'),
('971238164V', '(077) 787-8986'),
('971238164V', '(078) 565-4654'),
('983111912V', '(078) 125-4645'),
('984782483V', '(077) 654-6542'),
('986389878V', '(077) 654-3243');

-- --------------------------------------------------------

--
-- Table structure for table `notification`
--

DROP TABLE IF EXISTS `notification`;
CREATE TABLE IF NOT EXISTS `notification` (
  `NoteID` int(11) NOT NULL AUTO_INCREMENT,
  `Note` varchar(500) NOT NULL,
  PRIMARY KEY (`NoteID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `notification`
--

INSERT INTO `notification` (`NoteID`, `Note`) VALUES
(1, 'Attention :  Special Meeting at 8.00am');

-- --------------------------------------------------------

--
-- Table structure for table `other_guest_details`
--

DROP TABLE IF EXISTS `other_guest_details`;
CREATE TABLE IF NOT EXISTS `other_guest_details` (
  `GuestID` int(8) NOT NULL,
  `MemberNIC` varchar(15) NOT NULL,
  `MemberName` varchar(200) NOT NULL,
  PRIMARY KEY (`GuestID`,`MemberNIC`),
  KEY `GuestID` (`GuestID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `other_guest_details`
--

INSERT INTO `other_guest_details` (`GuestID`, `MemberNIC`, `MemberName`) VALUES
(3, '964512354V', 'Kapila De Silva'),
(4, '200014564', 'Sandaru De Silva'),
(4, '200145648962', 'Shehan Rajapaksha'),
(7, '986351645V', 'Sriyani Jayalath'),
(7, '986354789V', 'Shashika Jayasekara'),
(8, '895645621V', 'Wihangi Suresha'),
(8, '904565124V', 'Gayathri Jayasekara'),
(8, '986545875V', 'Nawoda Jay'),
(9, '200561254689', 'Kavindi Anuththara'),
(9, '200645789561', 'Shalani Wijesinghe'),
(9, '981245653V', 'Bhanuka Rajapaksha'),
(10, '200454685145', 'Sehansa Jayawickrama'),
(10, '200845678945', 'Nishadini Alwis'),
(12, '199245654565', 'Vinya Karunathilaka'),
(14, '56464646', 'dsadsad'),
(14, '983212458V', 'abcd'),
(14, '983254582V', 'abcd'),
(14, '983545612V', 'Amal perera');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
CREATE TABLE IF NOT EXISTS `payment` (
  `GuestID` int(8) NOT NULL,
  `payment` int(8) NOT NULL,
  `ToBePaid` int(8) NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`GuestID`,`payment`,`ToBePaid`,`date`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`GuestID`, `payment`, `ToBePaid`, `date`) VALUES
(3, 15, 7475, '2021-08-08 22:51:00'),
(3, 500, 8500, '2021-08-08 22:08:00'),
(3, 1000, 7500, '2021-08-08 22:44:00'),
(7, 1500, 10500, '2021-08-08 23:12:00'),
(10, 5000, 8000, '2021-08-09 02:27:00'),
(13, 15000, -15000, '2021-08-11 11:26:00'),
(13, 20000, 0, '2021-08-08 22:12:00'),
(14, 20000, 2400, '2021-08-09 13:51:00');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `GuestID` int(8) NOT NULL,
  `IDNumber` varchar(15) NOT NULL,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime DEFAULT NULL,
  PRIMARY KEY (`GuestID`,`IDNumber`),
  KEY `GuestID` (`GuestID`),
  KEY `IDno` (`IDNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`GuestID`, `IDNumber`, `StartDate`, `EndDate`) VALUES
(0, '0', '2021-08-08 01:08:55', '2021-08-08 01:08:55'),
(1, '198055465465', '2021-08-08 01:10:23', '2021-08-09 03:33:00'),
(2, '566499559', '2021-08-08 01:34:51', NULL),
(3, '199823787343', '2021-08-08 01:35:16', NULL),
(4, '659872234', '2021-08-08 01:41:06', NULL),
(5, '971238164V', '2021-08-08 01:41:46', NULL),
(6, '986389878V', '2021-08-08 01:45:29', NULL),
(7, '199656541321', '2021-08-08 11:17:38', NULL),
(8, '895645123V', '2021-08-08 12:07:31', NULL),
(9, '197945621452', '2021-08-08 12:27:50', NULL),
(10, '198545678514', '2021-08-08 14:54:31', NULL),
(11, '199956455645', '2021-08-08 14:58:35', NULL),
(12, '198245654654', '2021-08-08 15:00:14', NULL),
(13, '199456456546', '2021-08-08 15:43:52', NULL),
(14, '983111912V', '2021-08-11 11:23:34', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
CREATE TABLE IF NOT EXISTS `room` (
  `RoomID` tinyint(4) NOT NULL,
  `RoomCategoryID` char(3) NOT NULL,
  PRIMARY KEY (`RoomID`),
  UNIQUE KEY `RoomID_2` (`RoomID`),
  KEY `RoomCategoryID` (`RoomCategoryID`),
  KEY `RoomID` (`RoomID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`RoomID`, `RoomCategoryID`) VALUES
(17, 'DL'),
(18, 'DL'),
(19, 'DL'),
(20, 'DL'),
(11, 'DN'),
(12, 'DN'),
(13, 'DN'),
(14, 'DN'),
(15, 'DN'),
(16, 'DN'),
(26, 'FL'),
(27, 'FL'),
(28, 'FL'),
(29, 'FL'),
(30, 'FL'),
(21, 'FN'),
(22, 'FN'),
(23, 'FN'),
(24, 'FN'),
(25, 'FN'),
(7, 'SL'),
(8, 'SL'),
(9, 'SL'),
(10, 'SL'),
(1, 'SN'),
(2, 'SN'),
(3, 'SN'),
(4, 'SN'),
(5, 'SN'),
(6, 'SN');

-- --------------------------------------------------------

--
-- Table structure for table `room_booking`
--

DROP TABLE IF EXISTS `room_booking`;
CREATE TABLE IF NOT EXISTS `room_booking` (
  `GuestID` int(8) NOT NULL,
  `RoomID` tinyint(4) NOT NULL,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime DEFAULT NULL,
  PRIMARY KEY (`GuestID`,`RoomID`),
  KEY `RoomID` (`RoomID`),
  KEY `GuestID` (`GuestID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `room_booking`
--

INSERT INTO `room_booking` (`GuestID`, `RoomID`, `StartDate`, `EndDate`) VALUES
(1, 4, '2021-08-08 01:09:00', '2021-08-09 03:33:00'),
(2, 5, '2021-08-08 01:21:00', '2021-08-11 01:21:00'),
(2, 6, '2021-08-08 01:34:00', '2021-08-12 01:34:00'),
(3, 11, '2021-08-08 01:34:00', '2021-08-10 01:34:00'),
(4, 29, '2021-08-08 01:40:00', '2021-08-16 01:40:00'),
(5, 30, '2021-08-08 01:41:00', '2021-08-11 01:41:00'),
(6, 25, '2021-08-10 01:41:00', '2021-08-14 02:55:19'),
(7, 2, '2021-08-08 11:16:00', '2021-08-12 11:16:00'),
(8, 20, '2021-08-08 12:05:00', '2021-08-18 12:05:00'),
(9, 28, '2021-08-08 12:27:00', '2021-08-14 12:27:00'),
(10, 23, '2021-08-08 14:53:00', '2021-08-10 14:53:00'),
(11, 9, '2021-08-08 14:58:00', '2021-08-12 14:58:00'),
(12, 13, '2021-08-08 14:59:00', '2021-08-11 14:59:00'),
(13, 10, '2021-08-08 15:43:00', '2021-08-13 15:43:00'),
(14, 4, '2021-08-11 11:22:00', '2021-08-14 11:22:00'),
(14, 12, '2021-08-11 11:22:00', '2021-08-14 11:22:00');

-- --------------------------------------------------------

--
-- Table structure for table `room_catergory`
--

DROP TABLE IF EXISTS `room_catergory`;
CREATE TABLE IF NOT EXISTS `room_catergory` (
  `RoomCatergoryID` char(3) NOT NULL,
  `RoomCatergoryType` varchar(20) NOT NULL,
  `RoomPrice` int(6) NOT NULL,
  PRIMARY KEY (`RoomCatergoryID`),
  KEY `RoomCatergoryID` (`RoomCatergoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `room_catergory`
--

INSERT INTO `room_catergory` (`RoomCatergoryID`, `RoomCatergoryType`, `RoomPrice`) VALUES
('DL', 'Double Luxury Room', 5000),
('DN', 'Double Normal Room', 4000),
('FL', 'Family Luxury Room', 7500),
('FN', 'Family Normal Room', 6000),
('SL', 'Single Luxury Room', 3500),
('SN', 'Single Normal Room', 2500);

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
CREATE TABLE IF NOT EXISTS `services` (
  `ServicesID` smallint(6) NOT NULL,
  `ServiceType` varchar(30) NOT NULL,
  `ServicePrice` smallint(6) NOT NULL,
  PRIMARY KEY (`ServicesID`),
  KEY `ServicesID` (`ServicesID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`ServicesID`, `ServiceType`, `ServicePrice`) VALUES
(3, 'Full Package', 5000),
(4, 'Satellite TV', 500),
(5, 'Hot Water', 500),
(6, 'Extra Bed', 1000),
(7, 'Pets Allowed', 800);

-- --------------------------------------------------------

--
-- Table structure for table `service_booking`
--

DROP TABLE IF EXISTS `service_booking`;
CREATE TABLE IF NOT EXISTS `service_booking` (
  `GuestID` int(8) NOT NULL,
  `RoomID` tinyint(4) NOT NULL,
  `ServiceID` smallint(6) NOT NULL,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime DEFAULT NULL,
  PRIMARY KEY (`GuestID`,`RoomID`,`ServiceID`),
  KEY `GuestID` (`GuestID`),
  KEY `RoomID` (`RoomID`),
  KEY `ServiceID` (`ServiceID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `service_booking`
--

INSERT INTO `service_booking` (`GuestID`, `RoomID`, `ServiceID`, `StartDate`, `EndDate`) VALUES
(1, 4, 4, '2021-08-08 01:09:00', '2021-08-09 03:33:00'),
(1, 4, 5, '2021-08-08 01:09:00', '2021-08-09 03:33:00'),
(2, 5, 6, '2021-08-08 01:21:00', '2021-08-11 01:21:00'),
(2, 5, 7, '2021-08-08 01:21:00', '2021-08-11 01:21:00'),
(2, 6, 6, '2021-08-08 01:34:00', '2021-08-12 01:34:00'),
(2, 6, 7, '2021-08-08 01:34:00', '2021-08-12 01:34:00'),
(3, 11, 5, '2021-08-08 01:34:00', '2021-08-10 01:34:00'),
(4, 29, 4, '2021-08-08 01:40:00', '2021-08-16 01:40:00'),
(4, 29, 5, '2021-08-08 01:40:00', '2021-08-16 01:40:00'),
(4, 29, 6, '2021-08-08 01:40:00', '2021-08-16 01:40:00'),
(5, 30, 5, '2021-08-08 01:41:00', '2021-08-11 01:41:00'),
(6, 25, 6, '2021-08-10 01:41:00', '2021-08-14 02:56:50'),
(7, 2, 4, '2021-08-08 11:16:00', '2021-08-12 11:16:00'),
(8, 20, 5, '2021-08-08 12:05:00', '2021-08-18 12:05:00'),
(9, 28, 5, '2021-08-08 12:27:00', '2021-08-14 12:27:00'),
(10, 23, 5, '2021-08-08 14:53:00', '2021-08-10 14:53:00'),
(11, 9, 4, '2021-08-08 14:58:00', '2021-08-12 14:58:00'),
(12, 13, 4, '2021-08-08 14:59:00', '2021-08-11 14:59:00'),
(13, 10, 5, '2021-08-08 15:43:00', '2021-08-13 15:43:00'),
(14, 4, 4, '2021-08-11 11:22:00', '2021-08-14 11:22:00'),
(14, 4, 5, '2021-08-11 11:22:00', '2021-08-14 11:22:00'),
(14, 12, 5, '2021-08-11 11:22:00', '2021-08-14 11:22:00');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `EmpID` varchar(8) NOT NULL,
  `EmpFName` varchar(100) NOT NULL,
  `EmpFullName` varchar(500) NOT NULL,
  `EmpPositionID` varchar(8) NOT NULL,
  `EmpNIC` varchar(15) NOT NULL,
  `Gender` char(1) NOT NULL,
  `TP1` varchar(18) NOT NULL,
  `TP2` varchar(18) DEFAULT NULL,
  `EmpAddress` varchar(500) NOT NULL,
  `EmpPassword` varchar(10) DEFAULT NULL,
  `EmpEmail` varchar(200) DEFAULT NULL,
  `JoiningDate` date NOT NULL,
  `Photo` blob,
  `CopyNIC` blob,
  PRIMARY KEY (`EmpID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`EmpID`, `EmpFName`, `EmpFullName`, `EmpPositionID`, `EmpNIC`, `Gender`, `TP1`, `TP2`, `EmpAddress`, `EmpPassword`, `EmpEmail`, `JoiningDate`, `Photo`, `CopyNIC`) VALUES
('ADM1234', 'Amal', 'Amal Mendis', 'ADM', '803312345V', 'M', '(077) 564-5455', '', '465,Kuruwita, Ratnapura', 'ADM1234', 'amalmeni@gmail.com', '2015-12-01', NULL, 0x30),
('CHF3216', 'Saman', 'Saman Kumara', 'CHF', '199845432165', 'M', '(075) 454-6598', NULL, '45, Beliatta, Hambantota.', 'CHF3216', 'samankumara@gmail.com', '2018-07-07', NULL, 0x30),
('CHF6546', 'Tharindu', 'Tharindu Senanayaka', 'CHF', '804565465V', 'M', '(077) 878-7898', '', '89, Alawwa, Kegalle', 'CHF6546', 'senanana@gmail.com', '2020-12-26', NULL, 0x30),
('CLN5161', 'Nawoda', 'Nawoda Jayasinghe', 'CLN', '986351612V', 'F', '(071) 338-9039', NULL, '126, Galle Rd, Matara', 'CLN5161', 'nawoda@gmail.com', '2021-08-07', NULL, 0x30),
('CLN5645', 'Akalanka', 'Akalanka Rajapaksha', 'CLN', '983656458V', 'M', '(078) 554-5789', NULL, '34, Galenbindunu Wewa, Anuradhapura', 'CLN5645', 'nayanajith@gmail.com', '2021-08-07', NULL, 0x30),
('CLN6456', 'Dilshan', 'Dilshan Hettiarachchi', 'CLN', '943564562V', 'M', '(077) 456-5465', NULL, '34, Kandy Rd, Nittambuwa', 'CLN6456', 'hetti@gmail.com', '2021-08-08', NULL, 0x30),
('CSH1234', 'Samanthi', 'Samanthi Perera', 'CSH', '975312345V', 'F', '(070) 789-8878', NULL, '89, Kandy Rd, Kelaniya', 'CSH1234', '', '2019-07-01', NULL, 0x30),
('CSH6325', 'Chandiman ', 'Chandiman Keerthi Bandara', 'CSH', '984563259V', 'M', '(071) 556-9895', '', '45, William Street, Polonnaruwa', 'CSH6325', 'bandara@gmail.com', '2021-08-07', NULL, 0x30),
('RCP1234', 'Amali', 'Amali Samarathunga', 'RCP', '985312345V', 'F', '(089) 564-5665', NULL, '34,Matara Rd, Galle', 'RCP1234', 'samayanthi@gmail.com', '2020-07-02', NULL, 0x30),
('RCP3265', 'Pramodya', 'Pramodya Samarakoon', 'RCP', '994532651V', 'M', '(071) 558-9653', NULL, '45, Gannoruwa, Gatambe', 'RCP3265', 'pramodya@gmail.com', '2021-08-07', NULL, 0x30),
('RCP5168', 'Vishmi', 'Vishmi Ranasinghe', 'RCP', '986351689V', 'F', '(070) 564-6865', NULL, '12, Galle Rd, Colombo 07', 'RCP5168', 'vishmi@gmail.com', '2021-08-07', NULL, 0x30),
('SCR2565', 'Vinul', 'Vinul Thilakaratna', 'SCR', '953225654V', 'M', '(089) 455-6235', NULL, '45, Wattala, Colombo', 'SCR2565', 'vinul@gmail.com', '2016-08-07', NULL, 0x30),
('WTR3168', 'Sanju', 'Sanju Hashintha', 'WTR', '970831682V', 'M', '(077) 156-8899', NULL, '30, Pilimathalawa, Jaffna', 'WTR3168', 'sanju@gmail.com', '2021-08-07', NULL, 0x30),
('WTR4561', 'Abhiru', 'Abhiru Kumara', 'WTR', '962345614V', 'M', '(079) 335-6452', NULL, '34, Rikillagaskada, Padiyathalawa', 'WTR4561', 'bandara@gmail.com', '2016-08-07', NULL, 0x30),
('WTR5451', 'Sidath', 'Sidath Karunaratna', 'WTR', '200045654512', 'M', '(077) 561-2324', NULL, '12, Kurunegala Rd, Kuliyapitiya', 'WTR5451', 'simdath2000@gmail.com', '2021-08-07', NULL, 0x30),
('WTR5623', 'Venushan', 'Venushan Thushantha', 'WTR', '984656237V', 'M', '(075) 364-5899', NULL, '23, Mathugama, Kalutara', 'WTR5623', 'venthushantha@gmail.com', '2021-08-07', NULL, 0x30),
('WTR6456', 'Pushpakumara', 'Pushpakumara Kavinda', 'WTR', '903564564V', 'M', '(078) 564-5231', NULL, '56, Yapane Handiya, Anuradhapura', 'WTR6456', 'pushpay@gmail.com', '2016-01-07', NULL, 0x30);

-- --------------------------------------------------------

--
-- Table structure for table `userlogin`
--

DROP TABLE IF EXISTS `userlogin`;
CREATE TABLE IF NOT EXISTS `userlogin` (
  `StaffID` varchar(8) NOT NULL,
  `LoginTime` datetime NOT NULL,
  PRIMARY KEY (`StaffID`,`LoginTime`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `userlogin`
--

INSERT INTO `userlogin` (`StaffID`, `LoginTime`) VALUES
('ADM1234', '2021-08-09 13:52:00'),
('ADM1234', '2021-08-09 14:19:00'),
('ADM1234', '2021-08-09 14:21:00'),
('ADM1234', '2021-08-09 14:23:00'),
('ADM1234', '2021-08-09 18:43:00'),
('ADM1234', '2021-08-09 19:15:00'),
('ADM1234', '2021-08-09 19:32:00'),
('ADM1234', '2021-08-09 19:37:00'),
('ADM1234', '2021-08-10 21:16:00'),
('ADM1234', '2021-08-11 10:25:00'),
('ADM1234', '2021-08-11 11:26:00'),
('CSH1234', '2021-08-09 13:59:00'),
('CSH1234', '2021-08-09 14:24:00'),
('CSH1234', '2021-08-10 21:22:00'),
('CSH1234', '2021-08-10 21:24:00'),
('CSH1234', '2021-08-10 21:26:00'),
('CSH1234', '2021-08-11 10:27:00'),
('RCP1234', '2021-08-09 11:00:00'),
('RCP1234', '2021-08-09 11:25:00'),
('RCP1234', '2021-08-09 11:26:00'),
('RCP1234', '2021-08-09 11:27:00'),
('RCP1234', '2021-08-09 11:28:00'),
('RCP1234', '2021-08-09 11:29:00'),
('RCP1234', '2021-08-09 11:30:00'),
('RCP1234', '2021-08-09 11:32:00'),
('RCP1234', '2021-08-09 11:33:00'),
('RCP1234', '2021-08-09 11:34:00'),
('RCP1234', '2021-08-09 11:35:00'),
('RCP1234', '2021-08-09 11:37:00'),
('RCP1234', '2021-08-09 13:40:00'),
('RCP1234', '2021-08-09 13:46:00'),
('RCP1234', '2021-08-09 13:48:00'),
('RCP1234', '2021-08-09 14:09:00'),
('RCP1234', '2021-08-09 14:16:00'),
('RCP1234', '2021-08-10 21:11:00'),
('RCP1234', '2021-08-11 10:21:00'),
('RCP1234', '2021-08-11 11:21:00'),
('RCP1234', '2021-08-11 11:25:00');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `guest_tp`
--
ALTER TABLE `guest_tp`
  ADD CONSTRAINT `TP` FOREIGN KEY (`IDNum`) REFERENCES `guest_details` (`IDNumber`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `room`
--
ALTER TABLE `room`
  ADD CONSTRAINT `RoomCat` FOREIGN KEY (`RoomCategoryID`) REFERENCES `room_catergory` (`RoomCatergoryID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `room_booking`
--
ALTER TABLE `room_booking`
  ADD CONSTRAINT `Room` FOREIGN KEY (`RoomID`) REFERENCES `room` (`RoomID`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `service_booking`
--
ALTER TABLE `service_booking`
  ADD CONSTRAINT `RoomS` FOREIGN KEY (`RoomID`) REFERENCES `room` (`RoomID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `Service` FOREIGN KEY (`ServiceID`) REFERENCES `services` (`ServicesID`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
