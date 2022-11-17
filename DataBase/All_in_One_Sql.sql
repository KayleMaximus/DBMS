--USE master
--DROP DATABASE MilkTeaShop
CREATE DATABASE MilkTeaShop;
go
use MilkTeaShop;
GO    
--Product			(sản phẩm, số lượng, mức giá)
--ProductCategory	(phân loại thức uống như: cà phê, nước ngọt,...)
--Account			(thông tin đăng nhập)
--AccountRole		(vai trò của từng account: 0 là admin, 1 là quản lý, 2 là nhân viên)
--Staff				(thông tin chung của nhân viên)
--Bill				(thông tin của order: thông tin nhân viên, thông tin sản phẩm, ngày tháng in hóa đơn)
--BillProduct		(linking table chứa thông tin về số lượng sản phẩm được mua trong 1 hoặc nhiều hóa đơn)

CREATE TABLE ProductCategory
(
	id INT ,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	CONSTRAINT PK_ProductType PRIMARY KEY (id),
);

GO

CREATE TABLE Product
(
	id INT IDENTITY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT ,	--ID phân loại
	quantity INT NOT NULL,
	price INT NOT NULL DEFAULT 0,

	CONSTRAINT PK_Product PRIMARY KEY (id),
	CONSTRAINT FK_Prodcut FOREIGN KEY (idCategory) REFERENCES ProductCategory(id)
	ON UPDATE CASCADE
	ON DELETE SET NULL
);
GO

CREATE TABLE AccountRole
(
	id INT NOT NULL,
	RoleName NVARCHAR(100) NOT NULL,

	CONSTRAINT PK_AccountRole PRIMARY KEY (id)
);
GO

CREATE TABLE Account
(
	id INT IDENTITY,
	Username NVARCHAR(100) NOT NULL UNIQUE,
	Password NVARCHAR(1000) NOT NULL, --cấp 1000 phòng khi mã hóa mật khẩu thì số lượng ký tự sẽ tăng lên
	RoleID INT NOT NULL DEFAULT 2,			  --ID phân vai trò: 0 là admin, 1 là quản lý, 2 là nhân viên

	CONSTRAINT PK_Account PRIMARY KEY (id),
	CONSTRAINT FK_Account FOREIGN KEY (RoleID) REFERENCES AccountRole(id)
);
GO

CREATE TABLE Staff
(
	id INT IDENTITY UNIQUE,
	aid INT NOT NULL, --account ID
	FName NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	LName NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	Addr NVARCHAR(100) NOT NULL, 
	Phone NVARCHAR(10)NOT NULL,
	Birthday DATE NOT NULL, 
	Gender NVARCHAR(100) NOT NULL,

	CONSTRAINT PK_Staff PRIMARY KEY (id),
	CONSTRAINT FK_Staff FOREIGN KEY (aid) REFERENCES dbo.Account(id)
	ON UPDATE CASCADE
);

CREATE TABLE Bill
(
	id INT IDENTITY,
	OrderDate DATE NOT NULL DEFAULT GETDATE(),
	staffID INT NOT NULL,		--StaffID
	status INT NOT NULL DEFAULT 0,		-- 1: đã thanh toán  && 0: chưa thanh toán
	totalPrice INT DEFAULT 0
	CONSTRAINT PK_Bill PRIMARY KEY (id),
	FOREIGN KEY (staffID) REFERENCES Staff(id)
);
Go
CREATE TABLE BillProduct
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL ,		--BillID
	idProduct INT ,		--ProductID
	quantity INT NOT NULL DEFAULT 0,
	--TotalAmount INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idProduct) REFERENCES dbo.Product(id)
);
GO

INSERT INTO ProductCategory VALUES (1,N'Coffe')
INSERT INTO ProductCategory VALUES (2,N'TraSua')
INSERT INTO ProductCategory VALUES (3,N'Tra')
INSERT INTO ProductCategory VALUES (4,N'SuaTuoi')
INSERT INTO ProductCategory VALUES (5,N'Yogurst')
INSERT INTO ProductCategory VALUES (6,N'Machiota')
INSERT INTO ProductCategory VALUES (7,N'Topping')
INSERT INTO ProductCategory VALUES (8,N'ThuAnNhanh')


/* caphe*/
INSERT INTO Product VALUES ( N'Capuchino' ,1 , 10,25000)
INSERT INTO Product VALUES ( N'Cà phê đen' ,1 , 10, 20000)
INSERT INTO Product VALUES (  N'Cà phê sữa' ,1 , 10, 25000)
INSERT INTO Product VALUES (  N'Bạc xỉu' ,1 , 10, 20000)
INSERT INTO Product VALUES ( N'Cacao sữa nóng' ,1 , 10, 25000)

/* tra sua*/

INSERT INTO Product VALUES ( N'Trà sữa trân châu' ,2 , 10,25000)
INSERT INTO Product VALUES ( N'Trà sữa thái xanh' ,2 ,10, 20000)
INSERT INTO Product VALUES ( N'Trà sữa matcha' ,2 , 10,25000)
INSERT INTO Product VALUES ( N'Trà sữa socola' ,2 , 10,20000)
INSERT INTO Product VALUES (N'Trà sữa bạc hà' ,2 , 10,25000)
INSERT INTO Product VALUES ( N'Trà sữa khoai môn' ,2 ,10, 20000)
INSERT INTO Product VALUES (N'Trà sữa nho đen' ,2,10,25000)
INSERT INTO Product VALUES ( N'Trà sữa dâu' ,2 , 10,20000)
INSERT INTO Product VALUES ( N'Trà sữa hoa đậu biếc' , 2,10, 25000)
INSERT INTO Product VALUES ( N'Trà sữa mật ong' ,2, 10,20000)

/* tra*/

INSERT INTO Product VALUES ( N'Trà đào' ,3 ,10, 25000)
INSERT INTO Product VALUES ( N'Trà vải' ,3 ,10, 20000)
INSERT INTO Product VALUES ( N'Hồng trà' ,3 , 10,25000)
INSERT INTO Product VALUES ( N'Lục trà' ,3 ,10, 20000)
INSERT INTO Product VALUES ( N'Trà oải hương' ,3 ,10, 25000)
INSERT INTO Product VALUES ( N'Tà Atiso' ,3 ,10, 20000)
INSERT INTO Product VALUES ( N'Ô long trà' ,3 , 10,25000)
INSERT INTO Product VALUES ( N'Trà chanh kiwi' ,3 ,10, 20000)
INSERT INTO Product VALUES ( N'Trà chanh bưởi' ,3 ,10, 25000)
INSERT INTO Product VALUES ( N'Trà chanh mật ong' ,3 ,10, 20000)

/*Sữa tươi*/
INSERT INTO Product VALUES (  N'Sữa tươi đường đen' ,4,10, 25000)
INSERT INTO Product VALUES ( N'Sữa tươi bạc hà' ,4 ,10, 20000)
INSERT INTO Product VALUES (  N'Sữa tươi lá dứa' ,4 , 10,25000)
INSERT INTO Product VALUES (  N'Sữa tươi khoai môn' ,4 ,10, 20000)
/*Yogurt */

INSERT INTO Product VALUES (  N'Cacao đá xay' ,5 , 10,25000)
INSERT INTO Product VALUES ( N'Matcha đá xay' ,5 , 10,20000)
INSERT INTO Product VALUES (  N'Yogurt việt quốc' ,5 ,10, 25000)
INSERT INTO Product VALUES ( N'Yogurt dâu' ,5 , 10,20000)
INSERT INTO Product VALUES (  N'Yogurt nho đen' ,5 ,10, 25000)
INSERT INTO Product VALUES (  N'Yogurt Cam' ,5 , 10,20000)
INSERT INTO Product VALUES (  N'Yogurt chanh dây' ,5 , 10,25000)
INSERT INTO Product VALUES (  N'Yogurt phúc bồn tử' ,5 ,10, 20000)
INSERT INTO Product VALUES (  N'Yogurt xoài' ,5 ,10, 25000)
/*Machiato */
INSERT INTO Product VALUES (  N'Machiato hồng trà' ,6 ,10, 25000)
INSERT INTO Product VALUES (  N'Machiato lục trà' ,6 , 10,25000)
INSERT INTO Product VALUES (  N'Machiato ô long trà' ,6 ,10, 25000)
INSERT INTO Product VALUES (  N'Cacao đá xay' ,6 ,10, 25000)
/* Topping*/
INSERT INTO Product VALUES (  N'Thạch vải' ,7 , 10,25000)
INSERT INTO Product VALUES ( N'Thạch thủy tinh yogurt' ,7 , 10,20000)
INSERT INTO Product VALUES (  N'Thạch dâu' ,7 ,10, 25000)
INSERT INTO Product VALUES ( N'Thạch xoài' ,7 , 10,20000)
INSERT INTO Product VALUES (  N'Thạch Đào' ,7 ,10, 25000)
INSERT INTO Product VALUES (  N'Thach chanh dây' ,7 , 10,20000)
INSERT INTO Product VALUES (  N'Thạch Socola' ,7 , 10,25000)
INSERT INTO Product VALUES (  N'Thạch cà phê' ,7 ,10, 20000)
INSERT INTO Product VALUES (  N'Thạch trà xanh' ,7 ,10, 25000)

/* ThuAnNhanh*/
INSERT INTO Product VALUES (  N'Chả tôm' ,8 , 10,25000)
INSERT INTO Product VALUES ( N'Chả hũ' ,8 , 10,20000)
INSERT INTO Product VALUES (  N'Xúc xích lốc xoáy' , 8,10, 25000)
INSERT INTO Product VALUES ( N'Phô mai sữa' ,8 , 10,20000)
INSERT INTO Product VALUES (  N'Hot Dog' ,8 ,10, 25000)
INSERT INTO Product VALUES (  N'Cánh Gà ' ,8 , 10,20000)
INSERT INTO Product VALUES (  N'Đùi Gà' ,8 , 10,25000)
INSERT INTO Product VALUES (  N'Pizza' ,8 ,10, 20000)

Go

INSERT INTO AccountRole VALUES (0,N'Admin')
INSERT INTO AccountRole VALUES (1,N'Quản Lý')
INSERT INTO AccountRole VALUES (2,N'Nhân Viên')
GO

----Constrains
--Bảng Product khi cập nhật giá / số lượng sản phẩm sẽ lan truyền qua các bảng khác cập nhật giá theo
--Bảng Product Catagory khi cập nhật tên sẽ lan truyền sang các bảng khác cập nhật theo


---------------------------------------------------------------------TRIGGER--------------------------------------------------------------
USE MilkTeaShop
GO

--------------------------------kiểm tra insert product vào BillInfo để tăng/giảm số lượng sản phẩm đã tồn tại-------------------------------
--------------------------------không cho order dish nếu vượt quá số lượng tồn kho( OrderDish quantity > Storage quantity)--------------------------------
CREATE TRIGGER [dbo].[InserProductQuantity] 
ON dbo.BillProduct 
INSTEAD OF INSERT 
AS
BEGIN
	DECLARE @IDBill INT 
	DECLARE @idFood   INT
	DECLARE @quantityiNSERT INT
	DECLARE @productCOUNT INT --số lượng sản phẩm tồn tại trong hóa đơn (nếu có)
	----dùng bảng inserted để lấy thông tin dựa trên dạng trigger INSTEAD OF INSERT 
	SELECT @IDBill=idBill FROM inserted
	SELECT @idFood = idProduct FROM inserted
	SELECT @quantityiNSERT = quantity FROM inserted	

	
	SELECT @productCOUNT = quantity FROM dbo.BillProduct WHERE idBill = @IDBill AND idProduct = @idFood 


	------------------------------------------------------kiểm tra số lượng của kho trước khi cho order
	DECLARE @quan INT -- quantity from storage
	SELECT @quan = quantity FROM dbo.Product WHERE id = @idFood
	IF (@quantityiNSERT > @quan)
	BEGIN
		RAISERROR (N'Out Of Order!',16,1)
		ROLLBACK
		RETURN
	END

	------------------------------------------------------kiểm tra tồn tại để cập nhật số lượng
	IF((SELECT COUNT(*) FROM dbo.BillProduct WHERE idBill = @IDBill AND idProduct = @idFood) > 0) --KIỂM TRA SỰ TỒN TẠI CỦA SẢN PHẨM
	BEGIN
		--biến newcount để tính xem order
		DECLARE @newcount INT = @productCOUNT + @quantityiNSERT	
		IF(@newcount > 0 AND @quantityiNSERT > 0)	--nếu order tăng
		BEGIN
			UPDATE dbo.Product SET quantity -= @quantityiNSERT WHERE id = @idFood
			UPDATE dbo.BillProduct SET quantity = @newcount WHERE idBill = @IDBill AND idProduct = @idFood	--thêm sản phẩm nếu tăng order
		END
		ELSE	--nếu order giảm
        BEGIN
			UPDATE dbo.Product SET quantity -= @quantityiNSERT WHERE id = @idFood  --if(@newcount < 0 )
			DELETE dbo.BillProduct WHERE idBill = @IDBill AND idProduct = @idFood	--giảm sản phẩm nếu giảm order
		END
	END
	ELSE
	BEGIN
		UPDATE dbo.Product SET quantity -= @quantityiNSERT WHERE id = @idFood
		INSERT INTO dbo.BillProduct VALUES ( @IDBill, @idFood , @quantityiNSERT )
	END
END

GO
--------------------------------kiểm tra insert Product nếu trùng tên thì tăng/giảm số lượng--------------------------------
										--và kiểm tra số lượng còn tồn kho
CREATE TRIGGER [dbo].[InserDish]
ON dbo.Product
INSTEAD OF INSERT 
AS
BEGIN
	DECLARE @name NVARCHAR(50) 
	DECLARE @idCate INT
	DECLARE @quantityiNSERT INT
	DECLARE @price INT
    DECLARE @productCOUNT INT
	----dùng bảng inserted để lấy thông tin dựa trên dạng trigger INSTEAD OF INSERT 
	SELECT @name= name FROM inserted
	SELECT @idCate = idCategory from inserted
	SELECT @quantityiNSERT = quantity FROM inserted
	SELECT @price = price FROM inserted
	SELECT @productCOUNT = quantity FROM dbo.Product WHERE name = @name AND idCategory = @idCate

	IF((SELECT COUNT(*) FROM dbo.Product WHERE name = @name AND idCategory = @idCate) > 0) --KIỂM TRA SỰ TỒN TẠI CỦA SẢN PHẨM
	BEGIN
		DECLARE @newcount INT = @productCOUNT + @quantityiNSERT
		IF(@newcount > 0)
		BEGIN
		UPDATE dbo.Product SET quantity = @newcount, price = @price  WHERE name = @name AND idCategory = @idCate	--thêm sản phẩm nếu tăng order
		END
		ELSE
        BEGIN
		UPDATE dbo.Product SET quantity = 0 WHERE name = @name AND idCategory = @idCate	--giảm sản phẩm nếu giảm order
		END
	END
	ELSE
		BEGIN
			INSERT INTO Product VALUES( @name, @idCate, @quantityiNSERT, @price)	--nếu trưa tồn tại thì insert vào billproduct
		END
END

GO
--------------------------------không cho thanh toán những hóa đơn chưa mua hàng (total Price = 0 )--------------------------------
CREATE TRIGGER [dbo].[CheckTotalPrice]
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @totalPrice INT
	SELECT @totalPrice = totalPrice FROM inserted
	IF( @totalPrice <= 0 )
	BEGIN
		RAISERROR (N'No Product Found!',16,1)
		ROLLBACK
	END
END
Go
--------------------------------không cho xóa những Dish còn đang nằm bên order--------------------------------
CREATE TRIGGER [dbo].[DishStillinOrder]
ON dbo.Product
INSTEAD OF DELETE
as
BEGIN
	DECLARE @dishName NVARCHAR(50)
	SELECT @dishName = name FROM Deleted
	IF( (SELECT COUNT(*) FROM LoadUncheckDish WHERE name = @dishName) > 0 )
	BEGIN
		RAISERROR (N'There Are Dishes Still Ordering !',16,1)
		ROLLBACK
	END
	ELSE
	BEGIN
	    DELETE  FROM dbo.Product WHERE name = @dishName
	END
END
GO

--------------------------------------------------------trigger xóa quyền đăng nhập trên server khi delete khỏi account
CREATE TRIGGER [dbo].[CreateUserLogin] ON Account
FOR INSERT
AS
BEGIN
	DECLARE @user NVARCHAR(50), @password NVARCHAR(50), @type int, @db_name NVARCHAR(MAX)
	SET @db_name = DB_NAME()
	SELECT @user = Username, @password = Password, @type = RoleID
	FROM inserted
	
	EXEC('CREATE LOGIN [' + @user + '] WITH PASSWORD = '''+ @password +''', DEFAULT_DATABASE=[' + @db_name + ']')
	EXEC('CREATE USER [' + @user + '] FOR LOGIN [' + @user + ']')

	IF @type = 0
	BEGIN
		EXEC sp_addsrvrolemember @user, 'sysadmin'
		EXEC sp_addsrvrolemember @user, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @user, 'ProcessAdmin'
		EXEC sp_addrolemember 'db_owner', @user
		EXEC sp_addrolemember 'db_accessadmin', @user
		EXEC sp_addrolemember 'db_securityadmin', @user
		EXEC sp_addrolemember 'CEO', @user
		EXEC('USE master; GRANT ALTER ANY LOGIN TO [' + @user + '] WITH GRANT OPTION')
	END
	ELSE IF @type = 1
	BEGIN
		EXEC sp_addrolemember 'Manager', @user
		EXEC sp_addrolemember 'db_datareader', @user
	END
	ELSE
	BEGIN
		EXEC sp_addrolemember 'Staff', @user
		EXEC sp_addrolemember 'db_datareader', @user
	END
	--IF @active = 0
	--	EXEC('ALTER LOGIN [' + @user + '] DISABLE')
	--ELSE
	--	EXEC('ALTER LOGIN [' + @user + '] ENABLE')
END
go

--------------------------------------------------------trigger xóa quyền đăng nhập trên server khi delete khỏi account
CREATE TRIGGER DeleteUserLogin ON Account
FOR DELETE
AS
BEGIN
	DECLARE @user NCHAR(15)
	
	SELECT @user = Username
	FROM deleted
	
	EXEC('DROP USER [' + @user + ']')
	EXEC('DROP LOGIN [' + @user + ']')
END
GO
	
----------------------------------------------------------------View--------------------------------

---------------------------------------full menu giao diện chính VIEW
CREATE VIEW [loadMenu] AS 
SELECT * FROM dbo.Product 
GO
---------------------------------------Load tất cả bill chưa thanh toán
CREATE VIEW [loadUncheckBill] AS 
SELECT b.id AS BillID, s.FName AS Staff, b.OrderDate AS Date 
FROM dbo.Bill b, dbo.Staff s 
WHERE status = 0 AND b.staffID = s.id  
GO
---------------------------------------Load tất cả dish chưa thanh toán
CREATE VIEW [loadUncheckDish] AS 
SELECT b.id AS billID,PD.name, bp.quantity, PD.price, PD.price*bp.quantity AS totalPrice
FROM dbo.BillProduct AS BP, dbo.Bill AS B, dbo.Product AS PD 
WHERE BP.idBill = b.id AND BP.idProduct = pd.id AND b.status = 0
GO
---------------------------------------Load tất cả Role của employee
CREATE VIEW [loadAllRole] AS 
SELECT * FROM dbo.AccountRole WHERE id = 1 OR id = 2
GO
--------------------------------------Tất cả sản phẩm có trong kho
CREATE VIEW [LoadStorage] AS
SELECT p.name AS [Dish] , p.quantity AS [Quantity], p.price AS [Price] , pc.name AS [Catagory]
FROM dbo.Product p , dbo.ProductCategory  pc
WHERE pc.id = p.idCategory

go

---------------------------------------------------------------------Procs--------------------------------------------------------------

---------------------------------------đăng nhập bằng manager
CREATE PROC USP_LoginAsManager
@userName NVARCHAR(100),
@passWord NVARCHAR(100),
@roleAD INT = 0,
@roleMa INT = 1
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Username = @userName AND Password = @passWord AND (RoleID = @roleMa OR RoleID = @roleAD )
END
GO

---------------------------------------đăng nhập bằng employee
CREATE PROC USP_LoginAsEmployee
@userName  NVARCHAR(100),
@passWord NVARCHAR(100),
@roleEm INT = 2
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Username = @userName AND Password = @passWord AND RoleID = @roleEm
END
GO

--------------------------------------Tạo ra 1 Bill mới với ID của staff trong phiên làm việc-------------
CREATE PROC USP_InsertBill
@iDsaccount INT,
@totalPrice INT = 0
AS
BEGIN
	DECLARE @idstaff INT
	SELECT @idstaff = MAX(id) FROM dbo.Staff WHERE aid = @iDsaccount --từ id account lấy ra id của staff
    INSERT INTO dbo.Bill VALUES (GETDATE(), @iDstaff, 0, @totalPrice) --datechekin / staffid / status / total price
END
GO


--------------------------------------thêm order cho đơn hàng hiện tại với ID bill
CREATE PROC USP_InsertBillInfo
@idBill INT, @idProduct INT, @quantity INT
AS
BEGIN
    INSERT INTO dbo.BillProduct VALUES( @idBill, @idProduct, @quantity )
END
GO

---------------------------------------update lại hóa đơn khi thanh toán với ID bill
CREATE PROC USP_UpdateBillStatus
@bID INT,
@totalPrice INT
AS
BEGIN
    UPDATE dbo.Bill SET status = 1, totalPrice = @totalPrice WHERE id = @bID
END
GO

--------------------------------------thêm tài khoản
CREATE PROC USP_AddAccount
@userName NVARCHAR(50), @password NVARCHAR(50), @roleID INT
AS
BEGIN
    INSERT INTO dbo.Account VALUES( @userName, @password, @roleID )
END
GO

--------------------------------------thêm tài khoản có phân quyền
CREATE PROC USP_AddAccount2
@userName NVARCHAR(50), @password NVARCHAR(50), @RoleID INT
AS
BEGIN
	DECLARE @Ret INT
	EXEC @Ret = SP_ADDLOGIN @userName , @password, 'MilkTeaShop'

	EXEC @Ret = sp_grantdbaccess @userName, @userName
	IF(@Ret = 1 ) -- Trùng Login Name
	BEGIN
		EXEC SP_DROPLOGIN @userName
	END
	

	IF @RoleID = 0		--admin
	BEGIN
		EXEC sp_addsrvrolemember @userName, 'sysadmin'
		EXEC sp_addsrvrolemember @userName, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @userName, 'ProcessAdmin'
		EXEC sp_addrolemember 'CEO', @userName
	END
	ELSE IF @RoleID = 1	-- =manager
	BEGIN
		EXEC sp_addsrvrolemember @userName, 'sysadmin'
		EXEC sp_addsrvrolemember @userName, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @userName, 'ProcessAdmin'
		EXEC sp_addrolemember 'Manager', @userName
	END
	ELSE				--staff
	BEGIN
		--EXEC sp_addsrvrolemember @userName, 'ProcessAdmin'
	    EXEC sp_addrolemember 'Staff', @userName
	END

    INSERT INTO dbo.Account VALUES( @userName, @password, @roleID )
END
GO




------------------------------------load thông tin employee để cập nhật
CREATE PROC USP_UpdateStaffInfo
@aid INT, @FName NVARCHAR(50), @LName NVARCHAR(50), @addr NVARCHAR(50), @phone NVARCHAR(50), @bdate DATE, @gender NVARCHAR(10)
AS
BEGIN
	UPDATE dbo.Staff SET FName=@FName , LName=@LName,  Addr=@addr,Phone=@phone,Birthday=@bdate,Gender=@gender WHERE aid = @aid
END
GO


------------------------------------Thêm Dish
CREATE PROC USP_AddDish
@name NVARCHAR(50), @idCata INT , @quantity INT , @price NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Product VALUES (  @name , @idCata , @quantity , @price   )
END
GO

------------------------------------xóa Dish
CREATE PROC USP_DeleteDish
@name NVARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.Product WHERE name = @name
END
GO

-----------------------------------cập nhật cata
CREATE PROC USP_UpdateCata
@name NVARCHAR(50), @id INT
AS
BEGIN
    UPDATE dbo.ProductCategory SET name = @name WHERE id = @id
END
-----------------------------------------------------------------------------------------------------------------------------------------------


---------------------------------------------------------------------Function--------------------------------------------------------------
GO

---------------------------------------Load Menu món ăn theo danh mục-------------------------------------
CREATE FUNCTION UF_GetProduct (@iDcat INT)
RETURNS TABLE
AS 
RETURN
(
SELECT * FROM dbo.Product WHERE idCategory = @iDcat
)
GO
--------------------------------------Load thông tin đơn hàng qua bill ID từ bàng BillInfo----------------
CREATE FUNCTION UF_GetInfoWithBilliD (@Bid INT)
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM dbo.BillProduct WHERE idBill = @Bid
)
GO
--------------------------------------Load toàn bộ Menu thông tin hóa đơn dựa trên ID hóa đơn VERSION KO VIEW------------------
CREATE FUNCTION UF_GetMenu (@Bid INT)
RETURNS TABLE
AS
RETURN
(
	SELECT PD.name, bp.quantity, PD.price, PD.price*bp.quantity AS totalPrice
	FROM dbo.BillProduct AS BP, dbo.Bill AS B, dbo.Product AS PD 
	WHERE BP.idBill = b.id AND BP.idProduct = pd.id AND b.id = @Bid
)
GO
--------------------------------------Load toàn bộ Menu thông tin hóa đơn dựa trên ID hóa đơn VERSION CÓ VIEW------------------
CREATE FUNCTION UF_GetMenu2 (@Bid INT)
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM dbo.loaduncheckdish WHERE billID = @Bid
)
GO
---------------------------------------Lấy Bill dựa vào ngày ( thống kê)
CREATE FUNCTION UF_GetBillByDate ( @Date date )
RETURNS TABLE
AS
RETURN
(
    SELECT s.FName AS[Staff], b.totalPrice AS [Summation], b.OrderDate [Date]
	FROM dbo.Bill AS B, staff AS S
	WHERE B.status = 1 AND b.staffID = s.id AND b.OrderDate = @Date
)
GO
---------------------------------------kiểm tra trùng tên đăng nhập
CREATE FUNCTION UF_CheckUserName (@userName NVARCHAR(50) )
RETURNS TABLE
AS 
RETURN
(
	SELECT * FROM dbo.Account WHERE username = @userName
)
GO
---------------------------------------Tính tổng thu nhập theo ngày ( thống kê)
CREATE FUNCTION UF_SumByDate ( @Date DATE )
RETURNS INT
AS
BEGIN
	DECLARE @total INT
	SELECT @total = SUM(Summation) FROM UF_GetBillByDate ( @Date )
	RETURN @total
END
GO
---------------------------------------lấy toàn bộ thông tin staff dựa trên account ID vì mỗi account chỉ có 1 staff sở hữu
CREATE FUNCTION UF_GetStaffByAccountID (@aid INT )
RETURNS TABLE
AS 
RETURN
(
	SELECT * FROM dbo.Staff WHERE aid = @aid
)
GO
---------------------------------------Lấy dish dựa trên tên cata của view storage
CREATE FUNCTION UF_GetStorageCata (@nameCata NVARCHAR(50) )
RETURNS TABLE
AS 
RETURN
(
	SELECT * FROM dbo.LoadStorage WHERE Catagory = @nameCata
)
GO
---------------------------------------hàm biến chuỗi có dấu của Tiếng Việt thành không dấu để tìm kiếm
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 

	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 

	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 

	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 

	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN 
				IF @COUNTER=1 
					SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE 
					SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
					BREAK 
			END 
			SET @COUNTER1 = @COUNTER1 +1 
		END 
		SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END
Go
---------------------------------------Tìm kiếm Dish dựa trên tên gần đúng
CREATE FUNCTION UF_FindDish (@name NVARCHAR(50) )
RETURNS TABLE
AS 
RETURN
(
	SELECT * FROM dbo.LoadStorage where dbo.fuConvertToUnsign1(Dish) LIKE '%' + dbo.fuConvertToUnsign1( @name ) + '%'
)
GO


--Quyen Hanh Cua Admin
Create ROLE CEO 
--EXEC sp_addrolemember 'db_owner', CEO
--EXEC sp_addrolemember 'db_accessadmin', CEO
--EXEC sp_addrolemember 'db_securityadmin', CEO

--view 
GRANT SELECT ON loadMenu TO CEO
GRANT SELECT ON loadUncheckBill TO CEO
GRANT SELECT ON loadAllRole TO CEO
GRANT SELECT ON LoadStorage TO CEO
GRANT SELECT ON loadUncheckDish TO CEO

--function
GRANT SELECT ON UF_CheckUserName TO CEO
GRANT SELECT ON UF_GetBillByDate TO CEO
GRANT SELECT ON UF_GetInfoWithBilliD TO CEO
GRANT SELECT ON UF_GetMenu TO CEO
GRANT SELECT ON UF_GetMenu2 TO CEO
GRANT SELECT ON UF_GetProduct TO CEO
GRANT SELECT ON UF_GetStaffByAccountID TO CEO
GRANT SELECT ON UF_GetStorageCata TO CEO
GRANT SELECT ON UF_FindDish TO CEO
GRANT EXECUTE ON UF_SumByDate TO CEO

--stored procedure
GRANT EXECUTE ON USP_LoginAsManager TO CEO
GRANT EXECUTE ON USP_LoginAsEmployee TO CEO
GRANT EXECUTE ON USP_InsertBill TO CEO
GRANT EXECUTE ON USP_InsertBillInfo TO CEO
GRANT EXECUTE ON USP_UpdateBillStatus TO CEO
GRANT EXECUTE ON USP_AddAccount TO CEO
GRANT EXECUTE ON USP_AddAccount2 TO CEO
GRANT EXECUTE ON USP_UpdateStaffInfo TO CEO

GRANT EXECUTE ON USP_AddDish TO CEO
GRANT EXECUTE ON USP_DeleteDish TO CEO
GRANT EXECUTE ON USP_UpdateCata TO CEO
go


--Quyen Hanh Cua Quan Ly
Create ROLE Manager
--EXEC sp_addrolemember 'db_datareader', Manager
--EXEC sp_addrolemember 'db_datawriter', Manager

--view 
GRANT SELECT ON loadMenu TO Manager
GRANT SELECT ON loadUncheckBill TO Manager
GRANT SELECT ON loadAllRole TO Manager
GRANT SELECT ON LoadStorage TO Manager
GRANT SELECT ON loadUncheckDish TO Manager

--function
GRANT SELECT ON UF_CheckUserName TO Manager
GRANT SELECT ON UF_GetBillByDate TO Manager
GRANT SELECT ON UF_GetInfoWithBilliD TO Manager
GRANT SELECT ON UF_GetMenu TO Manager
GRANT SELECT ON UF_GetMenu2 TO Manager
GRANT SELECT ON UF_GetProduct TO Manager
GRANT SELECT ON UF_GetStaffByAccountID TO Manager
GRANT SELECT ON UF_GetStorageCata TO Manager
GRANT SELECT ON UF_FindDish TO Manager
GRANT EXECUTE ON UF_SumByDate TO Manager

--stored procedure
GRANT EXECUTE ON USP_LoginAsManager TO Manager
GRANT EXECUTE ON USP_InsertBill TO Manager
GRANT EXECUTE ON USP_InsertBillInfo TO Manager
GRANT EXECUTE ON USP_UpdateBillStatus TO Manager
GRANT EXECUTE ON USP_AddAccount TO Manager
GRANT EXECUTE ON USP_UpdateStaffInfo TO Manager

go



--Quyen Hanh Cua Nhan Vien
Create ROLE Staff
--EXEC sp_addrolemember 'db_datareader', Staff
--EXEC sp_addrolemember 'db_datawriter', Staff

--view 
GRANT SELECT ON loadMenu TO Staff
GRANT SELECT ON loadUncheckBill TO Staff
GRANT SELECT ON loadAllRole TO Staff
GRANT SELECT ON LoadStorage TO Staff
GRANT SELECT ON loadUncheckDish TO Staff

--function
GRANT SELECT ON UF_CheckUserName TO Staff
GRANT SELECT ON UF_GetMenu TO Staff
GRANT SELECT ON UF_GetMenu2 TO Staff
GRANT SELECT ON UF_GetProduct TO Staff
GRANT SELECT ON UF_GetStaffByAccountID TO Staff
GRANT SELECT ON UF_GetInfoWithBilliD TO Staff

--stored procedure
GRANT EXECUTE ON USP_LoginAsEmployee TO Staff
GRANT EXECUTE ON USP_InsertBill TO Staff
GRANT EXECUTE ON USP_InsertBillInfo TO Staff
GRANT EXECUTE ON USP_UpdateBillStatus TO Staff
GRANT EXECUTE ON USP_UpdateStaffInfo TO Staff
--GRANT EXECUTE ON USP_LoginAsManager TO Staff
--GRANT EXECUTE ON USP_AddAccount TO Staff
--GRANT EXECUTE ON USP_AddDish TO Staff
--GRANT EXECUTE ON USP_DeleteDish TO Staff
--GRANT EXECUTE ON USP_UpdateCata TO Staff
--GRANT SELECT ON UF_GetBillByDate TO Staff
--GRANT SELECT ON UF_GetStorageCata TO Staff
--GRANT SELECT ON UF_FindDish TO Staff
--GRANT EXECUTE ON UF_SumByDate TO Staff
go

INSERT INTO dbo.Account
(
    Username,
    Password,
    RoleID
)
VALUES
(   N'SuperAdmin', -- Username - nvarchar(100)
    N'Kayle', -- Password - nvarchar(1000)
    0    -- RoleID - int
    )
		go
INSERT INTO dbo.Account
(
    Username,
    Password,
    RoleID
)
VALUES
(   N'SuperManager', -- Username - nvarchar(100)
    N'Kayle', -- Password - nvarchar(1000)
    1    -- RoleID - int
    )
go
INSERT INTO dbo.Account
(
    Username,
    Password,
    RoleID
)
VALUES
(   N'SuperStaff', -- Username - nvarchar(100)
    N'Kayle', -- Password - nvarchar(1000)
    2    -- RoleID - int
    )
go

INSERT INTO Staff VALUES (1,N'Admin Kayle',N'Admin',N'81 Đỗ Năng Tế', '0924229366', '2008-7-04', N'Nam')
INSERT INTO Staff VALUES (2,N'Quản Lý',N'Manager 01',N'81 Đỗ Năng Tế', '12345676', '2008-7-04', N'nữ')
INSERT INTO Staff VALUES (3,N'Nhân viên 01',N'staff01',N'81 Đỗ Năng Tế', '12345676', '2008-7-04', N'nữ')

