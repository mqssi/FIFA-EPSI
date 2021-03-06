USE [FIFA]
GO
/****** Object:  Table [dbo].[But]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[But](
	[ID_But] [int] IDENTITY(1,1) NOT NULL,
	[Min_But] [time](7) NOT NULL,
	[Csc_But] [bit] NOT NULL,
	[ID_Joueur] [int] NOT NULL,
	[ID_Match] [int] NOT NULL,
 CONSTRAINT [PK_But] PRIMARY KEY CLUSTERED 
(
	[ID_But] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competition]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competition](
	[ID_Competition] [int] IDENTITY(1,1) NOT NULL,
	[Comp_Nom] [nvarchar](250) NOT NULL,
	[Comp_Date] [datetime] NULL,
	[Comp_Gagnant] [nvarchar](250) NULL,
	[Comp_Nbjoueur] [int] NULL,
	[Active] [bit] NULL,
	[ID_Equipe] [int] NULL,
 CONSTRAINT [PK_Comp] PRIMARY KEY CLUSTERED 
(
	[ID_Competition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompetitionEntry]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompetitionEntry](
	[ID_CompetitionEnt] [int] IDENTITY(1,1) NOT NULL,
	[ID_Equipe] [int] NOT NULL,
	[ID_Competition] [int] NOT NULL,
 CONSTRAINT [PK_CompetitionEntry] PRIMARY KEY CLUSTERED 
(
	[ID_CompetitionEnt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipe]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipe](
	[ID_Equipe] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Equipe] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Equipe2] PRIMARY KEY CLUSTERED 
(
	[ID_Equipe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Joueur]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Joueur](
	[ID_Joueur] [int] IDENTITY(1,1) NOT NULL,
	[Pseudo_Joueur] [nvarchar](250) NOT NULL,
	[Nom_Joueur] [nvarchar](250) NOT NULL,
	[Prenom_Joueur] [nvarchar](250) NOT NULL,
	[Mail_Joueur] [nvarchar](250) NOT NULL,
	[Equipe_Joueur] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Joueur] PRIMARY KEY CLUSTERED 
(
	[ID_Joueur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Match]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Match](
	[ID_Match] [int] IDENTITY(1,1) NOT NULL,
	[ID_Gagnant] [int] NULL,
	[ID_Competition] [int] NOT NULL,
	[Match_Round] [int] NOT NULL,
 CONSTRAINT [PK_Match] PRIMARY KEY CLUSTERED 
(
	[ID_Match] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchEntry]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchEntry](
	[ID_MatchEntry] [int] IDENTITY(1,1) NOT NULL,
	[ID_Match] [int] NOT NULL,
	[ID_MatchParent] [int] NULL,
	[ID_EquipeJouant] [int] NULL,
	[Score] [float] NULL,
 CONSTRAINT [PK_Equipe] PRIMARY KEY CLUSTERED 
(
	[ID_MatchEntry] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MembreEquipe]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MembreEquipe](
	[ID_MembreEquipe] [int] IDENTITY(1,1) NOT NULL,
	[ID_Equipe] [int] NOT NULL,
	[ID_Joueur] [int] NOT NULL,
 CONSTRAINT [PK_MembreEquipe] PRIMARY KEY CLUSTERED 
(
	[ID_MembreEquipe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[But]  WITH CHECK ADD  CONSTRAINT [FK_But_Joueur] FOREIGN KEY([ID_Joueur])
REFERENCES [dbo].[Joueur] ([ID_Joueur])
GO
ALTER TABLE [dbo].[But] CHECK CONSTRAINT [FK_But_Joueur]
GO
ALTER TABLE [dbo].[CompetitionEntry]  WITH CHECK ADD  CONSTRAINT [FK_CompetitionEntry_Competition] FOREIGN KEY([ID_Competition])
REFERENCES [dbo].[Competition] ([ID_Competition])
GO
ALTER TABLE [dbo].[CompetitionEntry] CHECK CONSTRAINT [FK_CompetitionEntry_Competition]
GO
ALTER TABLE [dbo].[CompetitionEntry]  WITH CHECK ADD  CONSTRAINT [FK_CompetitionEntry_Equipe] FOREIGN KEY([ID_Equipe])
REFERENCES [dbo].[Equipe] ([ID_Equipe])
GO
ALTER TABLE [dbo].[CompetitionEntry] CHECK CONSTRAINT [FK_CompetitionEntry_Equipe]
GO
ALTER TABLE [dbo].[Match]  WITH CHECK ADD  CONSTRAINT [FK_Match_Competition] FOREIGN KEY([ID_Competition])
REFERENCES [dbo].[Competition] ([ID_Competition])
GO
ALTER TABLE [dbo].[Match] CHECK CONSTRAINT [FK_Match_Competition]
GO
ALTER TABLE [dbo].[MatchEntry]  WITH CHECK ADD  CONSTRAINT [FK_MatchEntry_Equipe] FOREIGN KEY([ID_EquipeJouant])
REFERENCES [dbo].[Equipe] ([ID_Equipe])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MatchEntry] CHECK CONSTRAINT [FK_MatchEntry_Equipe]
GO
ALTER TABLE [dbo].[MatchEntry]  WITH CHECK ADD  CONSTRAINT [FK_MatchEntry_Match] FOREIGN KEY([ID_Match])
REFERENCES [dbo].[Match] ([ID_Match])
GO
ALTER TABLE [dbo].[MatchEntry] CHECK CONSTRAINT [FK_MatchEntry_Match]
GO
ALTER TABLE [dbo].[MembreEquipe]  WITH CHECK ADD  CONSTRAINT [FK_MembreEquipe_Equipe] FOREIGN KEY([ID_Equipe])
REFERENCES [dbo].[Equipe] ([ID_Equipe])
GO
ALTER TABLE [dbo].[MembreEquipe] CHECK CONSTRAINT [FK_MembreEquipe_Equipe]
GO
ALTER TABLE [dbo].[MembreEquipe]  WITH CHECK ADD  CONSTRAINT [FK_MembreEquipe_Joueur] FOREIGN KEY([ID_Joueur])
REFERENCES [dbo].[Joueur] ([ID_Joueur])
GO
ALTER TABLE [dbo].[MembreEquipe] CHECK CONSTRAINT [FK_MembreEquipe_Joueur]
GO
/****** Object:  StoredProcedure [dbo].[Comp_GetALL]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Comp_GetALL]
	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	from dbo.Competition
	where Active = 1;
	

END
GO
/****** Object:  StoredProcedure [dbo].[Joueur_GetALL]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Joueur_GetALL]


AS
BEGIN



	SELECT Pseudo_Joueur, Nom_Joueur, Prenom_Joueur, Mail_Joueur, ID_Joueur FROM dbo.Joueur
END
GO
/****** Object:  StoredProcedure [dbo].[Joueur_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Joueur_Insert]
	@Pseudo_Joueur nvarchar(50),
	@Nom_Joueur nvarchar(50),
	@Prenom_Joueur nvarchar(50),
	@Mail_Joueur nvarchar(50),
	@Equipe_Joueur nvarchar(50),
	@ID_Joueur int = 0 output


AS
BEGIN
	SET NOCOUNT ON;


INSERT INTO dbo.Joueur(Pseudo_Joueur,Nom_Joueur,Prenom_Joueur,Mail_Joueur, Equipe_Joueur)
VALUES(@Pseudo_Joueur,@Nom_Joueur,@Prenom_Joueur,@Mail_Joueur, @Equipe_Joueur)

select @ID_Joueur = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[Match_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Match_Insert]
	@ID_Competition int,
	@Match_Round int,
	@ID_Match int  = 0 output

AS
BEGIN
	insert into dbo.Match (ID_Competition, Match_Round)
	VALUES (@ID_Competition, @Match_Round);
	SELECT @ID_Match = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[MatchEntry_GetByMatch]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MatchEntry_GetByMatch]
	@ID_Match int
AS
BEGIN

	SET NOCOUNT ON;


	select *
	from MatchEntry
	where ID_Match =  @ID_Match;


END
GO
/****** Object:  StoredProcedure [dbo].[MatchEntry_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MatchEntry_Insert] 
	@ID_Match int,
	@ID_MatchParent int,
	@ID_EquipeJouant int,
	@ID_MatchEntry int = 0 output

AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.MatchEntry(ID_Match, ID_MatchParent, ID_EquipeJouant)
	VALUES (@ID_Match, @ID_MatchParent, @ID_EquipeJouant)

	SELECT @ID_MatchEntry = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spComp_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spComp_Insert]
	@Comp_Nom nvarchar(250),
	@ID_Competition int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Competition(Comp_Nom, Comp_Date, Active)
	values (@Comp_Nom, CURRENT_TIMESTAMP, 1)

	SELECT @ID_Competition = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spCompEntry_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCompEntry_Insert]
	@ID_Competition int,
	@ID_Equipe int,
	@ID_CompetitionEnt int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

INSERT INTO dbo.CompetitionEntry(ID_Competition, ID_Equipe )
VALUES (@ID_Competition, @ID_Equipe);

SELECT @ID_CompetitionEnt = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spCompEquipe_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCompEquipe_Insert]
	
	@ID_Equipe int



AS
BEGIN

	SET NOCOUNT ON;
		insert into dbo.Competition(Comp_Nom, Comp_Date,ID_Equipe, Active)
	values (Null, Null, @ID_Equipe, NULL)

END
GO
/****** Object:  StoredProcedure [dbo].[spComplete_Comp]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spComplete_Comp]
	@ID_Competition int
AS
BEGIN

	SET NOCOUNT ON;


	update dbo.Competition
	set Active= 0
	where ID_Competition = @ID_Competition;



END
GO
/****** Object:  StoredProcedure [dbo].[spEquipe_GetALL]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEquipe_GetALL]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.Equipe;
END
GO
/****** Object:  StoredProcedure [dbo].[spEquipe_GetByComp]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEquipe_GetByComp]
@ID_Competition int


AS
BEGIN

	SET NOCOUNT ON;


	select t.*
	from dbo.Equipe t
	inner join dbo.CompetitionEntry e on t.ID_Equipe = e.ID_Equipe
	where e.ID_Competition = @ID_Competition;
END
GO
/****** Object:  StoredProcedure [dbo].[spEquipes_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEquipes_Insert]
	@Nom_Equipe nvarchar(250),
	@ID_Equipe INT = 0 output



AS
BEGIN

	SET NOCOUNT ON;
	insert into dbo.Equipe (Nom_Equipe)
	values (@Nom_Equipe);
	select @ID_Equipe = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[spMatch_GetByComp]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatch_GetByComp]
@ID_Competition int


AS
BEGIN

	SET NOCOUNT ON;


	select m.*
	from dbo.Match m
	where m.ID_Competition = @ID_Competition
	order by Match_Round;
END
GO
/****** Object:  StoredProcedure [dbo].[spMatch_Update]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatch_Update]
	@ID_Match int,
	@ID_Gagnant int
AS
BEGIN

	SET NOCOUNT ON;

	update dbo.Match
	set ID_Gagnant = @ID_Gagnant
	where ID_Match = @ID_Match;


END
GO
/****** Object:  StoredProcedure [dbo].[spMatchEntry_Update]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchEntry_Update]
		@ID_MatchEntry int,
		@ID_EquipeJouant int = null,
		@Score float = null


AS
BEGIN

	SET NOCOUNT ON;

	update dbo.MatchEntry
	set ID_EquipeJouant = @ID_EquipeJouant, Score = @Score
	where ID_MatchEntry = @ID_MatchEntry;


END
GO
/****** Object:  StoredProcedure [dbo].[spME_GetParEquipe]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[spME_GetParEquipe] 

@ID_Equipe int


AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT j.*
	from dbo.MembreEquipe m
	inner join dbo.Joueur j on m.ID_Joueur = j.ID_Joueur
	where m.ID_Equipe = @ID_Equipe;
END
GO
/****** Object:  StoredProcedure [dbo].[spMembreEquipe_Insert]    Script Date: 10/05/2020 18:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMembreEquipe_Insert]
	@ID_Equipe int,
	@ID_Joueur int,
	@ID_MembreEquipe INT = 0 output



AS
BEGIN

	SET NOCOUNT ON;
	insert into dbo.MembreEquipe(ID_Equipe, ID_Joueur)
	values (@ID_Equipe,@ID_Joueur );
	select @ID_MembreEquipe = SCOPE_IDENTITY();

END
GO

