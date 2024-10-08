USE [Gadgets]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[client_id] [int] IDENTITY(1,1) NOT NULL,
	[client_name] [varchar](50) NULL,
	[phone_number] [varchar](15) NULL,
 CONSTRAINT [PK__clients__BF21A4242BA197B3] PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gadgets]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gadgets](
	[gadget_id] [int] IDENTITY(1,1) NOT NULL,
	[gadget_name] [varchar](50) NULL,
 CONSTRAINT [PK__gadgets__F08D36CCC71E66B9] PRIMARY KEY CLUSTERED 
(
	[gadget_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invoices]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invoices](
	[invoice_id] [int] NOT NULL,
	[order_id] [int] NULL,
	[invoice_date] [date] NULL,
	[total_amount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NULL,
	[gadget_id] [int] NULL,
	[issue] [varchar](255) NULL,
	[status] [varchar](50) NULL,
	[price] [decimal](18, 0) NULL,
 CONSTRAINT [PK__orders__465962294BA603EB] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parts]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parts](
	[part_id] [int] IDENTITY(1,1) NOT NULL,
	[part_name] [varchar](50) NULL,
	[part_for_gadget] [int] NULL,
	[quantity_available] [int] NULL,
 CONSTRAINT [PK__parts__A0E3FAB801F6D4D3] PRIMARY KEY CLUSTERED 
(
	[part_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payments]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payments](
	[payment_id] [int] NOT NULL,
	[invoice_id] [int] NULL,
	[payment_date] [date] NULL,
	[payment_amount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[repair_status]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[repair_status](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [varchar](50) NULL,
 CONSTRAINT [PK__repair_s__3683B531433169F2] PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clients] ON 

INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (1, N'Александр Иванов', N'123-456-7890')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (2, N'Екатерина Петрова', N'987-654-3210')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (3, N'Дмитрий Смирнов', N'555-123-4567')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (4, N'Ольга Козлова', N'777-888-9999')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (5, N'Сергей Федоров', N'444-333-2222')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (6, N'Наталья Васильева', N'666-555-4444')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (7, N'Иван Сидоров', N'111-222-3333')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (8, N'Мария Николаева', N'999-888-7777')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (9, N'Павел Кузнецов', N'222-333-4444')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (10, N'Анна Соколова', N'888-777-6666')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (12, N'Виктор Камболин', N'89617096136')
INSERT [dbo].[clients] ([client_id], [client_name], [phone_number]) VALUES (13, N'Николас Клетцов', N'1111-2222-3333')
SET IDENTITY_INSERT [dbo].[clients] OFF
GO
SET IDENTITY_INSERT [dbo].[gadgets] ON 

INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (1, N'Смартфон')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (2, N'Ноутбук')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (3, N'Планшет')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (4, N'Умные часы')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (5, N'Фотоаппарат')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (6, N'Наушники')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (7, N'Игровая консоль')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (8, N'Электрический чайник')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (9, N'Холодильник')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (10, N'Стиральная машина')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (11, N'POCO X3 PRO')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (12, N'Стиральная машина ZWZ')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (13, N'Телефон')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (14, N'Телефон ZZIW')
INSERT [dbo].[gadgets] ([gadget_id], [gadget_name]) VALUES (15, N'Телевизор')
SET IDENTITY_INSERT [dbo].[gadgets] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (1, 1, 3, N'Не включается', N'В обработке', CAST(1200 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (2, 4, 6, N'Не работает правое наушник', N'В ремонте', CAST(3700 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (3, 2, 1, N'Низкий заряд батареи', N'Завершен', CAST(2300 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (4, 3, 4, N'Не показывает время', N'В процессе', CAST(4800 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (5, 7, 2, N'Не загружается Windows', N'В обработке', CAST(6000 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (6, 5, 7, N'Плохое качество изображения', N'В ремонте', CAST(800 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (7, 8, 8, N'Протекает', N'В процессе', CAST(1900 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (8, 6, 9, N'Не морозит', N'В обработке', CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (9, 10, 10, N'Не отжимает белье', N'Завершен', CAST(4000 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (10, 9, 5, N'Ошибка объектива', N'В ремонте', CAST(7000 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (11, 12, 11, N'У телефона сломалось защитное стекло. Установите новое.', N'В обработке', CAST(8000 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (12, 12, 12, N'Барабан перестал отжимать вещи', N'В обработке', CAST(4999 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (13, 12, 13, N'Перестал работать дисплей', N'В обработке', CAST(6789 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (14, 13, 14, N'Батарея перестала заряжаться', N'Completed', CAST(5400 AS Decimal(18, 0)))
INSERT [dbo].[orders] ([order_id], [client_id], [gadget_id], [issue], [status], [price]) VALUES (15, 13, 15, N'Замена экрана', N'Завершен', CAST(12222 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[parts] ON 

INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (1, N'Аккумулятор', 1, 50)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (2, N'Клавиатура', 2, 30)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (3, N'Дисплей', 3, 20)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (4, N'Стекло', 4, 40)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (5, N'Зарядное устройство', 5, 25)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (6, N'Динамик', 6, 35)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (7, N'Геймпад', 7, 15)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (8, N'Нагревательный элемент', 8, 10)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (9, N'Мотор', 9, 5)
INSERT [dbo].[parts] ([part_id], [part_name], [part_for_gadget], [quantity_available]) VALUES (10, N'Сливной насос', 10, 8)
SET IDENTITY_INSERT [dbo].[parts] OFF
GO
SET IDENTITY_INSERT [dbo].[repair_status] ON 

INSERT [dbo].[repair_status] ([status_id], [status_name]) VALUES (1, N'В обработке')
INSERT [dbo].[repair_status] ([status_id], [status_name]) VALUES (2, N'В ремонте')
INSERT [dbo].[repair_status] ([status_id], [status_name]) VALUES (3, N'В процессе')
INSERT [dbo].[repair_status] ([status_id], [status_name]) VALUES (4, N'Завершен')
SET IDENTITY_INSERT [dbo].[repair_status] OFF
GO
ALTER TABLE [dbo].[invoices]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK__orders__client_i__286302EC] FOREIGN KEY([client_id])
REFERENCES [dbo].[clients] ([client_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK__orders__client_i__286302EC]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK__orders__gadget_i__29572725] FOREIGN KEY([gadget_id])
REFERENCES [dbo].[gadgets] ([gadget_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK__orders__gadget_i__29572725]
GO
ALTER TABLE [dbo].[parts]  WITH CHECK ADD  CONSTRAINT [FK__parts__part_for___2C3393D0] FOREIGN KEY([part_for_gadget])
REFERENCES [dbo].[gadgets] ([gadget_id])
GO
ALTER TABLE [dbo].[parts] CHECK CONSTRAINT [FK__parts__part_for___2C3393D0]
GO
ALTER TABLE [dbo].[payments]  WITH CHECK ADD FOREIGN KEY([invoice_id])
REFERENCES [dbo].[invoices] ([invoice_id])
GO
/****** Object:  StoredProcedure [dbo].[DeletePart]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePart](
    @part_id INT
)
AS
BEGIN
    DELETE FROM parts
    WHERE part_id = @part_id;
END;

GO
/****** Object:  StoredProcedure [dbo].[GetOrdersByClientAndStatus]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Хранимые процедуры возвращающие данные
CREATE PROCEDURE [dbo].[GetOrdersByClientAndStatus](
    @client_name VARCHAR(50),
    @gadget_status VARCHAR(50)
)
AS
BEGIN
    SELECT o.order_id, c.client_name, g.gadget_name, o.issue, o.status
    FROM orders o
    JOIN clients c ON o.client_id = c.client_id
    JOIN gadgets g ON o.gadget_id = g.gadget_id
    WHERE c.client_name = @client_name AND o.status = @gadget_status;
END;

GO
/****** Object:  StoredProcedure [dbo].[GetPartsByGadgetAndQuantity]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPartsByGadgetAndQuantity](
    @gadget_id INT,
    @min_quantity INT,
    @max_quantity INT
)
AS
BEGIN
    SELECT part_id, part_name, quantity_available
    FROM parts
    WHERE part_for_gadget = @gadget_id AND quantity_available BETWEEN @min_quantity AND @max_quantity;
END;

GO
/****** Object:  StoredProcedure [dbo].[InsertNewClient]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Хранимые процедуры не возвращающие данные
CREATE PROCEDURE [dbo].[InsertNewClient](
    @client_name VARCHAR(50),
    @phone_number VARCHAR(15)
)
AS
BEGIN
    INSERT INTO clients (client_name, phone_number)
    VALUES (@client_name, @phone_number);
END;

GO
/****** Object:  StoredProcedure [dbo].[UpdateOrderStatus]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOrderStatus](
    @order_id INT,
    @new_status VARCHAR(50)
)
AS
BEGIN
    UPDATE orders
    SET status = @new_status
    WHERE order_id = @order_id;
END;

GO
/****** Object:  Trigger [dbo].[trg_PreventClientDeletion]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Создание триггера на ограничение
CREATE TRIGGER [dbo].[trg_PreventClientDeletion]
ON [dbo].[clients]
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM deleted d JOIN orders o ON d.client_id = o.client_id)
    BEGIN
        RAISERROR ('Cannot delete client with active orders', 16, 1);
    END
    ELSE
    BEGIN
        DELETE c
        FROM clients c
        JOIN deleted d ON c.client_id = d.client_id;
    END
END;
GO
ALTER TABLE [dbo].[clients] ENABLE TRIGGER [trg_PreventClientDeletion]
GO
/****** Object:  Trigger [dbo].[trg_CascadeDeleteParts]    Script Date: 10.03.2024 12:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Создание триггера на каскадное удаление
CREATE TRIGGER [dbo].[trg_CascadeDeleteParts]
ON [dbo].[gadgets]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE p
    FROM parts p
    JOIN deleted d ON p.part_for_gadget = d.gadget_id;
END;
GO
ALTER TABLE [dbo].[gadgets] ENABLE TRIGGER [trg_CascadeDeleteParts]
GO
