drop table if exists demo_class;
drop table if exists demo_course;
drop table if exists demo_user;
drop table if exists demo_user_course;
drop view if exists v_demo_user_course;

/*==============================================================*/
/* Table: demo_class                                            */
/*==============================================================*/
create table demo_class
(
   ClassID              varchar(10) not null  comment '类别编码',
   Name                 varchar(10)  comment '类别',
   Sort1                int not null  comment '',
   Sort2                int not null  comment '',
   primary key (ClassID)
);

alter table demo_class comment '类别
这里有很多说明';

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create unique index index_1 on demo_class
(
   Sort1,
   Sort2
);

/*==============================================================*/
/* Table: demo_course                                           */
/*==============================================================*/
create table demo_course
(
   Year                 year(4) not null  comment '学年',
   CourseID             char(36) not null  comment '课程编码（GUID）',
   Name                 varchar(10)  comment '名称',
   OrderNum             int not null  comment '',
   primary key (Year, CourseID)
);

alter table demo_course comment '课程';

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create unique index index_1 on demo_course
(
   OrderNum
);

/*==============================================================*/
/* Table: demo_user                                             */
/*==============================================================*/
create table demo_user
(
   UserID               bigint not null auto_increment  comment '用户编码（自增字段）',
   ClassID              varchar(10)  comment '类别编码',
   FBit                 bit not null default 1  comment '字段1
                     多行1
                     多行2',
   FBit_Max             bit(64)  comment '',
   FTinyInt             tinyint not null default 127  comment '',
   FTinyInt_Unsigned    tinyint unsigned default 255  comment '',
   FBool                bool  comment '',
   F_Boolean            boolean not null default 1  comment '',
   FBool_TinyInt        tinyint(1) default 0  comment '',
   FSmallInt            smallint not null default -32768  comment '',
   FSmallInt_Unsigned   smallint unsigned default 65535  comment '',
   FMediumInt           mediumint not null default -8388608  comment '',
   FMediumInt_Unsigned  mediumint unsigned  comment '',
   FInt                 int not null default -2147483648  comment '',
   FInt_Unsigned        int unsigned default 4294967295  comment '',
   F_Integer            Integer  comment '',
   FBigInt              bigint not null default -9223372036854775808  comment '',
   FBigInt_Unsigned     bigint unsigned  comment '',
   FFloat               float not null default 12.345678  comment '',
   FFloat_Max           float(7,4) unsigned  comment '',
   FDouble              double not null default 123456789.1234567  comment '',
   FDouble_Max          double(15,4) unsigned  comment '',
   F_Real               real  comment '',
   F_Double_Precision   double precision unsigned  comment '',
   FYear                year(4)  comment '',
   FDate                date  comment '',
   FTime                time  comment '',
   FTimestamp           timestamp default CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP  comment '',
   FDateTime            datetime  comment '',
   FChar                char(4)  comment '',
   FVarChar             varchar(255)  comment '',
   FBinary              binary(2)  comment '',
   FVarBinary           varbinary(2)  comment '',
   FTinyText            tinytext  comment '',
   FText                text  comment '',
   FMediumText          mediumtext  comment '',
   FLongText            longtext  comment '',
   FTinyBlob            tinyblob  comment '',
   FBlob                blob  comment '',
   FMediumBlob          mediumblob  comment '',
   FLongBlob            longblob  comment '',
   FEnum                enum('m','f')  comment '',
   FSet                 set('one','two')  comment '',
   FDecimal             decimal not null default 123.45  comment '',
   FDecimal_Max         decimal(65,30) unsigned  comment '',
   F_Numeric            numeric  comment '',
   F_Dec                dec  comment '',
   F_Fixed              fixed  comment '',
   primary key (UserID)
);

alter table demo_user comment '用户表';

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on demo_user
(
   FInt
);

/*==============================================================*/
/* Index: index_3                                               */
/*==============================================================*/
create index index_3 on demo_user
(
   FYear,
   FDate
);

/*==============================================================*/
/* Table: demo_user_course                                      */
/*==============================================================*/
create table demo_user_course
(
   UserID               bigint not null  comment '用户编码（自增字段）',
   Year                 year(4) not null  comment '学年',
   CourseID             char(36) not null  comment '课程编码（GUID）',
   Note                 text  comment '说明',
   primary key (UserID, CourseID, Year)
);

alter table demo_user_course comment '用户分类表';


/*==============================================================*/
/* View: v_demo_user_course                                     */
/*==============================================================*/
create VIEW  v_demo_user_course
 as
select t2.UserID, t2.ClassID, t3.CourseID, t3.Name, t1.Note, '测试列' as TestColumn
from demo_user_course as t1
	left join demo_user as t2 on t1.UserID = t2.UserID
	left join demo_course as t3 on t1.CourseID = t3.CourseID;

alter table demo_user add constraint FK_DEMO_USE_REFERENCE_DEMO_CLA foreign key (ClassID)
      references demo_class (ClassID) on delete restrict on update restrict;

alter table demo_user_course add constraint FK_DEMO_USE_REFERENCE_DEMO_USE foreign key (UserID)
      references demo_user (UserID) on delete restrict on update restrict;

alter table demo_user_course add constraint FK_DEMO_USE_REFERENCE_DEMO_COU foreign key (Year, CourseID)
      references demo_course (Year, CourseID) on delete restrict on update restrict;


create procedure p_demo_get_user_course(in pUserID bigint,out pPageCount int)
comment '存储过程描述'
begin
	select count(0) into pPageCount from demo_user_course where UserID = pUserID;
	select * from demo_user_course where UserID = pUserID;
	select 'abc';
	-- return 123
end;

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Records of demo_class
-- ----------------------------
INSERT INTO `demo_class` VALUES ('A001', '班级001', '1', '1');
INSERT INTO `demo_class` VALUES ('A002', '班级002', '1', '2');
INSERT INTO `demo_class` VALUES ('A003', '班级003', '2', '1');

-- ----------------------------
-- Records of demo_course
-- ----------------------------
INSERT INTO `demo_course` VALUES ('2001', '7CF78E4B-D2EC-4B18-926E-CF3503D64FDD', '语文', '1');
INSERT INTO `demo_course` VALUES ('2001', '86110DD4-4254-49A2-A312-1DAC92A87EC1', '数学', '2');
INSERT INTO `demo_course` VALUES ('2002', 'EC312A0B-8243-4ABE-95DD-B0F9B4B8BB0D', '英语', '3');

-- ----------------------------
-- Records of demo_user
-- ----------------------------
INSERT INTO `demo_user` VALUES ('1', 'A001', '\0', null, '127', '255', '1', '0', null, '-32768', '65535', '-8388608', '16777215', '-2147483648', '4294967295', null, '-9223372036854775808', '18446744073709551615', '12.3457', '12.3457', '123456789.1234567', null, null, '12.34', '2001', '2001-02-03', '12:34:56', '2017-11-30 10:07:57', '2001-02-03 04:05:06', 'A01', 'B02', null, null, 'aaa', 'bbb', 'ccc', 'ddd', null, null, null, null, 'f', 'two', '12345', '123.456000000000000000000000000000', '12345', '12345', '12345');
INSERT INTO `demo_user` VALUES ('2', 'A001', '', '\0\0\0\0\0\0\0\0', '-128', null, '0', '0', '0', '32767', null, '8388607', null, '2147483647', null, '-1', '9223372036854775807', null, '123.457', '123.4568', '123.123456789', '12.3400', '56.78', null, null, null, null, '2017-11-21 19:59:08', null, null, null, null, null, null, null, null, null, null, null, null, null, 'f', 'one', '321', null, null, null, null);
INSERT INTO `demo_user` VALUES ('3', 'A002', '', null, '-1', '1', null, '0', null, '0', null, '-1', null, '-1', '0', null, '-1', '0', '2.2', null, '123456789.1234567', null, null, null, null, null, null, '2017-11-21 19:59:20', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '1', null, null, null, null);
INSERT INTO `demo_user` VALUES ('4', 'A003', '', null, '-2', '2', null, '1', null, '-1', null, '-2', null, '-2', null, null, '-2', null, '3.3', null, '123456789.1234567', null, null, null, null, null, null, '2017-11-21 19:59:20', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '2', null, null, null, null);
INSERT INTO `demo_user` VALUES ('5', 'A003', '', null, '-3', '3', null, '0', null, '-2', null, '-3', null, '-3', null, null, '-3', null, '4.4', null, '123456789.1234567', null, null, null, null, null, null, '2017-11-21 19:59:21', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '3', null, null, null, null);
INSERT INTO `demo_user` VALUES ('6', 'A003', '', null, '-4', '4', null, '1', null, '-3', null, '-4', null, '-4', null, null, '-4', null, '5.5', null, '123456789.1234567', null, null, null, null, null, null, '2017-11-21 19:59:21', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '4', null, null, null, null);


-- ----------------------------
-- Records of demo_user_course
-- ----------------------------
INSERT INTO `demo_user_course` VALUES ('1', '2001', '7CF78E4B-D2EC-4B18-926E-CF3503D64FDD', 'aaa');
INSERT INTO `demo_user_course` VALUES ('1', '2001', '86110DD4-4254-49A2-A312-1DAC92A87EC1', 'ccc');
INSERT INTO `demo_user_course` VALUES ('2', '2001', '7CF78E4B-D2EC-4B18-926E-CF3503D64FDD', 'bbb');
INSERT INTO `demo_user_course` VALUES ('2', '2001', '86110DD4-4254-49A2-A312-1DAC92A87EC1', 'eee');
INSERT INTO `demo_user_course` VALUES ('2', '2002', 'EC312A0B-8243-4ABE-95DD-B0F9B4B8BB0D', 'ttt');
INSERT INTO `demo_user_course` VALUES ('3', '2002', 'EC312A0B-8243-4ABE-95DD-B0F9B4B8BB0D', 'ggg');

DELIMITER ;
