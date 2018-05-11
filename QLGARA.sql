CREATE DATABASE QuanLyGara
USE QuanLyGara
GO

CREATE TABLE KHACHHANG (
   MAKH					INT IDENTITY(1,1)    NOT NULL,
   TENKH                NVARCHAR(30)         NOT NULL,
   DIACHI               NVARCHAR(50)         NOT NULL,
   DIENTHOAI            VARCHAR(15)          NOT NULL,
   EMAIL                VARCHAR(30)          NOT NULL,
   CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH)
)
GO

CREATE TABLE XE (
   BIENSO               VARCHAR(20)          NOT NULL,
   MAKH                 INT                  NOT NULL,
   HIEUXE               NVARCHAR(20)         NOT NULL,
   CONSTRAINT PK_XE PRIMARY KEY (BIENSO),
   CONSTRAINT FK_XE_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
)
GO

CREATE TABLE PHIEUNHAN (
   MAPHIEUNHAN          INT IDENTITY(1,1552) NOT NULL,
   BIENSO               VARCHAR(20)          NOT NULL,
   NGAYNHAN             DATETIME			 NOT NULL,
   CONSTRAINT PK_PHIEUNHAN PRIMARY KEY (MAPHIEUNHAN),
   CONSTRAINT FK_PHIEUNHAN_XE FOREIGN KEY (BIENSO) REFERENCES XE(BIENSO)
)
GO

CREATE TABLE PHUTUNG (
   MAPHUTUNG            VARCHAR(10)          NOT NULL,
   TENPHUTUNG           NVARCHAR(50)         NOT NULL,
   DONGIA               INT					 NOT NULL,
   CONSTRAINT PK_PHUTUNG PRIMARY KEY (MAPHUTUNG)
)
GO

CREATE TABLE CONGVIEC (
   MACONGVIEC           VARCHAR(10)          NOT NULL,
   NOIDUNG              NVARCHAR(60)         NOT NULL,
   TIENCONG             INT					 NOT NULL,
   CONSTRAINT PK_CONGVIEC PRIMARY KEY (MACONGVIEC)
)
GO

CREATE TABLE PHIEUSUACHUA (
   MAPHIEUSUA           INT IDENTITY(1,20304)NOT NULL,
   BIENSO               VARCHAR(20)          NOT NULL,
   NGAYSUA              DATETIME			 NOT NULL,
   TINHTRANG            VARCHAR(10)			 NOT NULL,
   CONSTRAINT PK_PHIEUSUACHUA PRIMARY KEY (MAPHIEUSUA),
   CONSTRAINT FK_PHIEUSUACHUA_XE FOREIGN KEY (BIENSO) REFERENCES XE(BIENSO),
)
GO

CREATE TABLE PHIEUTHU (
   MAPHIEUTHU           INT                  NOT NULL,
   MAPHIEUSUA           INT                  NOT NULL,
   NGAYTHU              DATETIME			 NOT NULL,
   TIENTHU              INT					 NOT NULL,
   CONSTRAINT PK_PHIEUTHU PRIMARY KEY (MAPHIEUTHU),
   CONSTRAINT FK_PHIEUTHU_PHIEUSUACHUA FOREIGN KEY (MAPHIEUSUA) REFERENCES PHIEUSUACHUA(MAPHIEUSUA)
)
GO

CREATE TABLE CT_PHIEUSUA (
   MAPHIEUSUA           INT					 NOT NULL,
   MAPHUTUNG            VARCHAR(10)          NOT NULL,
   MACONGVIEC           VARCHAR(10)          NOT NULL,
   SL_PHUTUNG           INT						 NULL,
   CONSTRAINT PK_CT_PHIEUSUA PRIMARY KEY (MAPHIEUSUA, MAPHUTUNG, MACONGVIEC),
   CONSTRAINT FK_CT_PHIEUSUA_PHIEUSUA FOREIGN KEY (MAPHIEUSUA) REFERENCES PHIEUSUACHUA(MAPHIEUSUA),
   CONSTRAINT FK_CT_PHIEUSUA_PHUTUNG FOREIGN KEY (MAPHUTUNG) REFERENCES  PHUTUNG(MAPHUTUNG),
   CONSTRAINT FK_CT_PHIEUSUA_CONGVIEC FOREIGN KEY (MACONGVIEC) REFERENCES CONGVIEC(MACONGVIEC)
)
GO



