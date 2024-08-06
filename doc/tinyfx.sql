/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2022/11/23 20:28:52                          */
/*==============================================================*/


drop procedure if exists p_demo_get_user_course;

drop view if exists v_demo_user_course;

drop view if exists v_admin_user_role_priv;

drop view if exists v_admin_user_owner_priv;

drop table if exists admin_dicts;

drop table if exists admin_group;

drop table if exists admin_listedit;

drop table if exists admin_listedit_edititem;

drop table if exists admin_listedit_gridcolumn;

drop table if exists admin_listedit_queryitem;

drop table if exists admin_menu;

drop table if exists admin_msg;

drop table if exists admin_oper_log;

drop table if exists admin_req_log;

drop table if exists admin_role;

drop table if exists admin_role_menu;

drop table if exists admin_site;

drop table if exists admin_user;

drop table if exists admin_user_priv;

drop table if exists demo_class;

drop table if exists demo_course;

drop table if exists demo_user;

drop table if exists demo_user_course;

/*==============================================================*/
/* Table: admin_dicts                                           */
/*==============================================================*/
create table admin_dicts
(
   DictID               varchar(40) not null  comment '编码GUID',
   Category             varchar(50)  comment '类别',
   Name                 varchar(200)  comment '描述',
   Value                text  comment '值',
   Type                 int not null default 0  comment '类型0-系统1-用户定义',
   primary key (DictID)
);

alter table admin_dicts comment '后台字典';

/*==============================================================*/
/* Table: admin_group                                           */
/*==============================================================*/
create table admin_group
(
   GroupID              int not null  comment '编码',
   GroupName            varchar(100)  comment '名称',
   `Desc`               text  comment '描述',
   ParentID             int  comment '父编码',
   primary key (GroupID)
);

alter table admin_group comment '部门或组';

/*==============================================================*/
/* Table: admin_listedit                                        */
/*==============================================================*/
create table admin_listedit
(
   GenID                bigint not null auto_increment  comment '编码',
   ConnectionStringName varchar(50)  comment '查询连接字符串名',
   QuerySQLSource       text  comment '原始SQL',
   QuerySQL             text  comment 'SQL解析后SelectStatement的json',
   QueryTitle           varchar(100)  comment '查询页面Title',
   PageSize             int not null default 20  comment 'Grid页大小',
   GridHeight           int not null default 600  comment 'Grid高度',
   TableName            varchar(100)  comment '删除表名',
   PrimaryKeys          varchar(2000)  comment '主键集合json序列化',
   HasDelete            bool not null default 0  comment '是否有删除',
   DeleteSQL            varchar(1000)  comment '删除SQL',
   HasAdd               bool not null default 0  comment '是否有添加',
   AddSQL               text  comment '添加SQL',
   HasEdit              bool not null default 0  comment '是否有编辑',
   HasView              bool not null default 0  comment '是否有查看',
   SelectSQL            text  comment '编辑获取数据SQL',
   EditSQL              text  comment '编辑SQL',
   EditTitle            varchar(100)  comment '添加编辑页面Title',
   EditWidth            int not null default 0  comment '添加编辑页面宽度',
   HasDialog            bool not null default 0  comment '是否有Dialog功能（只支持单一主键）',
   DialogSQL            varchar(1000)  comment '对话框SQL',
   DialogFieldName      varchar(50)  comment '对话框列名',
   DialogWidth          int not null default 0  comment '对话框宽度',
   DialogHeight         int not null default 0  comment '对话框高度',
   Status               tinyint not null default 1  comment '状态 0-初始 1-有效 2-无效',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录日期',
   primary key (GenID)
);

alter table admin_listedit comment '自定义SQL查询添加编辑模板数据';

/*==============================================================*/
/* Table: admin_listedit_edititem                               */
/*==============================================================*/
create table admin_listedit_edititem
(
   EditItemID           bigint not null auto_increment  comment '编码',
   GenID                bigint not null  comment 'Gen编码',
   ColumnName           varchar(50)  comment '列名',
   IsPrimaryKey         bool not null default 0  comment '是否主键',
   ControlType          varchar(50)  comment '控件类型',
   ControlID            varchar(50)  comment '控件ID',
   FieldLabel           varchar(50)  comment 'Label',
   RowIndex             int not null default 0  comment '所在行',
   ColumnIndex          int not null default 0  comment '所在列',
   WidthNum             int not null default 0  comment '宽度',
   EditParameterName    varchar(50)  comment '参数名',
   EditDbType           varchar(50)  comment '参数类型',
   EditDotNetType       varchar(100)  comment '参数DotNet类型',
   DefaultValueSet      varchar(50)  comment '默认值类型',
   DefaultValueString   varchar(50)  comment '默认值字符串',
   JsonData             text  comment 'Json系列化',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录日期',
   primary key (EditItemID)
);

alter table admin_listedit_edititem comment '添加编辑控件定义';

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on admin_listedit_edititem
(
   GenID
);

/*==============================================================*/
/* Table: admin_listedit_gridcolumn                             */
/*==============================================================*/
create table admin_listedit_gridcolumn
(
   GridColumnID         bigint not null auto_increment  comment '编码',
   GenID                bigint not null  comment '编码',
   OrderNum             int not null default 0  comment '排序',
   ColumnType           varchar(50)  comment '列类型',
   IsPrimaryKey         bool not null default 0  comment '是否主键',
   FieldName            varchar(50)  comment '数据字段名',
   ColumnName           varchar(50)  comment '数据表列名',
   Text                 varchar(50)  comment '显示列名',
   Align                varchar(50)  comment '对齐方式',
   Width                varchar(10)  comment '列宽',
   Flex                 int  comment '列宽flex',
   Locked               bool not null default 0  comment '是否锁定',
   Visible              bool not null default 1  comment '是否可见',
   Format               varchar(50)  comment '显示格式',
   TrueText             varchar(50)  comment 'BooleanColumn true文本',
   FalseText            varchar(50)  comment 'BooleanColumn false文本',
   FilterType           varchar(50)  comment '过滤类型',
   RenderFn             varchar(50)  comment '输出显示函数名',
   RenderFnContent      text  comment '输出显示函数内容',
   RenderHandler        varchar(1000)  comment '输出显示handler',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录日期',
   primary key (GridColumnID)
);

alter table admin_listedit_gridcolumn comment '查询grid列定义';

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on admin_listedit_gridcolumn
(
   GenID,
   OrderNum
);

/*==============================================================*/
/* Table: admin_listedit_queryitem                              */
/*==============================================================*/
create table admin_listedit_queryitem
(
   QueryItemID          bigint not null auto_increment  comment '编码',
   GenID                bigint not null  comment 'Gen编码',
   QueryBlock           varchar(255)  comment '查询语句块',
   QueryParameterName   varchar(50)  comment '查询参数名',
   QueryDbType          varchar(50)  comment '参数DbType类型',
   QueryDotNetType      varchar(100)  comment '参数DotNet类型',
   ControlType          varchar(50)  comment '控件类型',
   ControlID            varchar(50)  comment '控件ID',
   FieldLabel           varchar(50)  comment 'Label',
   RowIndex             int not null default 0  comment '所在行',
   ColumnIndex          int not null default 0  comment '所在列',
   JsonData             text  comment 'Json系列化',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录日期',
   primary key (QueryItemID)
);

alter table admin_listedit_queryitem comment '查询条件控件定义';

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on admin_listedit_queryitem
(
   GenID
);

/*==============================================================*/
/* Table: admin_menu                                            */
/*==============================================================*/
create table admin_menu
(
   MenuID               varchar(40) not null  comment '菜单编码GUID',
   SiteID               varchar(50)  comment '站点编码',
   ParentId             varchar(40) default '0'  comment '父菜单编码 0-根菜单',
   Title                varchar(50)  comment '菜单显示标题',
   OrderNum             int not null default 0  comment '排序，从小到大',
   Icon                 varchar(250)  comment '图标',
   LinkMode             int not null default 0  comment '链接类型0-目录1-rul 2-siteid+url 3-GenID',
   Url                  varchar(250)  comment '菜单URL，尽量使用相对路径',
   GenID                varchar(50)  comment 'GenID编码',
   UrlTarget            tinyint not null default 0  comment '链接模式 0-TAB打开 1-新窗口打开',
   PrivParams           varchar(250)  comment '功能和数据权限参数。格式：类型-参数| 类型-参数
             用于在定义页面内权限时可设置的权限选项列表
             如：ControlID-btnOk|ControlID-btnCancle',
   Pinyin               varchar(20)  comment '拼音',
   `Desc`               varchar(500)  comment '描述',
   Status               tinyint not null default 0  comment '状态 0-无效 1-有效',
   primary key (MenuID)
);

alter table admin_menu comment '管理菜单';

/*==============================================================*/
/* Table: admin_msg                                             */
/*==============================================================*/
create table admin_msg
(
   MsgID                varchar(40) not null  comment '编码GUID',
   UserID               varchar(40)  comment '用户',
   Flag                 int not null  comment '标识',
   `From`               varchar(50)  comment '来源',
   Title                varchar(100)  comment '标题',
   Content              text  comment '内容',
   `Label`              varchar(50)  comment '',
   Status               int not null  comment '状态0-未知1-有效2-删除',
   SendDate             datetime not null  comment '发送时间',
   primary key (MsgID)
);

alter table admin_msg comment '消息';

/*==============================================================*/
/* Table: admin_oper_log                                        */
/*==============================================================*/
create table admin_oper_log
(
   LogID                varchar(40) not null  comment '日志编码GUID',
   OperType             varchar(150) default '0'  comment '操作的种类（根据业务自行约定）
             sql --数据库操作
             ',
   Title                varchar(255)  comment '操作描述',
   Content              text  comment '内容',
   Tag1                 varchar(100)  comment '标记1',
   Tag2                 varchar(100)  comment '标记2',
   Tag3                 varchar(100)  comment '标记3',
   Tag4                 varchar(100)  comment '标记3',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间',
   primary key (LogID)
);

alter table admin_oper_log comment '后台管理操作日志';

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on admin_oper_log
(
   RecDate,
   OperType
);

/*==============================================================*/
/* Table: admin_req_log                                         */
/*==============================================================*/
create table admin_req_log
(
   LogID                varchar(40) not null  comment '编码GUID',
   UserID               varchar(40)  comment '管理用户ID',
   Type                 int not null  comment '类型0-登录1-请求',
   Result               varchar(50)  comment '结果',
   RequestUrl           varchar(255)  comment '请求地址',
   IP                   varchar(50)  comment 'IP地址',
   OS                   varchar(50)  comment '系统',
   Browser              varchar(50)  comment '浏览器',
   Location             varchar(100)  comment '地址',
   UserAgent            text  comment '其他',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录日期',
   primary key (LogID)
);

alter table admin_req_log comment '登录请求日志';

/*==============================================================*/
/* Table: admin_role                                            */
/*==============================================================*/
create table admin_role
(
   RoleID               int not null  comment '角色标识',
   RoleName             varchar(50)  comment '角色名称',
   `Desc`               varchar(255)  comment '描述',
   Status               tinyint not null default 0  comment '状态 0-无效 1-有效',
   primary key (RoleID)
);

alter table admin_role comment '角色表';

/*==============================================================*/
/* Table: admin_role_menu                                       */
/*==============================================================*/
create table admin_role_menu
(
   RoleID               int not null  comment '权限标识',
   MenuID               varchar(40) not null  comment '菜单编码GUID',
   PrivParamsValue      text  comment '功能和数据权限参数。
             类型-参数-是否有权限| 类型-参数-是否有权限
             如：ControlID-btnOk-true|ControlID-btnCancle-false
             
             ',
   primary key (RoleID, MenuID)
);

alter table admin_role_menu comment '用户菜单权限，对单个菜单授权，不针对目录';

/*==============================================================*/
/* Table: admin_site                                            */
/*==============================================================*/
create table admin_site
(
   SiteID               varchar(50) not null  comment '站点编码',
   SiteName             varchar(50)  comment '站点名称',
   BaseUrl              varchar(255)  comment '基础路径',
   `Desc`               text  comment '描述',
   Status               tinyint not null default 0  comment '状态 0-无效 1-有效',
   primary key (SiteID)
);

alter table admin_site comment '后台管理站点';

/*==============================================================*/
/* Table: admin_user                                            */
/*==============================================================*/
create table admin_user
(
   UserID               varchar(40) not null  comment '用户ID GUID',
   UserName             varchar(50)  comment '登录用户名',
   Password             varchar(255)  comment '登录密码',
   PasswordSalt         varchar(40)  comment '密码哈希Salt',
   Mobile               varchar(20)  comment '手机号',
   DisplayName          varchar(20)  comment '显示用户名',
   `Desc`               text  comment '描述',
   GroupID              int  comment '分组编码',
   IsAdmin              bool not null default 0  comment '是否管理员',
   RegisterDate         datetime not null  comment '注册时间',
   ApprovedDate         datetime  comment '审批时间',
   ApprovedBy           varchar(50)  comment '审批者',
   RejectDate           datetime  comment '拒绝时间',
   RejectBy             varchar(50)  comment '拒绝者',
   Status               tinyint not null default 0  comment '状态 0-无效 1-有效',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录日期',
   Icon                 varchar(255)  comment '头像',
   primary key (UserID)
);

alter table admin_user comment '后台用户表
where status=1 时 username唯一';

/*==============================================================*/
/* Table: admin_user_priv                                       */
/*==============================================================*/
create table admin_user_priv
(
   UserID               varchar(40) not null  comment '管理用户ID',
   PrivType             int not null default 0  comment '权限类型 0-site 1-role 2-menu',
   PrivID               varchar(100) not null  comment '角色编码或菜单编码',
   IsEnabled            bool not null default 1  comment '是否允许',
   PrivParamsValue      text  comment '功能和数据权限参数。格式：类型-参数| 类型-参数
             用于在定义页面内权限时可设置的权限选项列表
             如：ControlID-btnOk|ControlID-btnCancle',
   primary key (UserID, PrivType, PrivID)
);

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
   ClassID              varchar(10) not null  comment '类别编码',
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
/* View: v_admin_user_owner_priv                                */
/*==============================================================*/
create VIEW  v_admin_user_owner_priv
 as
select b2.*, -1 as RoleID, b1.PrivParamsValue,b1.IsEnabled, b1.UserID from admin_user_priv b1
	join admin_menu b2 on b1.PrivID=b2.MenuID and b2.`status`=1
where b1.PrivType=2;

/*==============================================================*/
/* View: v_admin_user_role_priv                                 */
/*==============================================================*/
create VIEW  v_admin_user_role_priv
 as
select a2.*, a1.IsEnabled,a1.UserID from admin_user_priv a1 
	join 
		(
		select t2.*,t1.RoleID,t1.PrivParamsValue 
		from admin_role_menu t1
			join admin_menu t2 on t1.MenuID = t2.MenuId and t2.`status`=1
			join admin_role t3 on t1.RoleID = t3.RoleID and t3.`status`=1
		) a2 on a1.PrivID=a2.RoleID 
where a1.PrivType=1;

/*==============================================================*/
/* View: v_demo_user_course                                     */
/*==============================================================*/
create VIEW  v_demo_user_course
 as
select t2.UserID, t2.ClassID, t3.CourseID, t3.Name, t1.Note, '测试列' as TestColumn
from demo_user_course as t1
	left join demo_user as t2 on t1.UserID = t2.UserID
	left join demo_course as t3 on t1.CourseID = t3.CourseID;


create procedure p_demo_get_user_course(in pUserID bigint,out pPageCount int)
comment '存储过程描述'
begin
	select count(0) into pPageCount from demo_user_course where UserID = pUserID;
	select * from demo_user_course where UserID = pUserID;
	select 'abc';
	-- return 123
end;

