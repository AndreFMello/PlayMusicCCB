CREATE DATABASE dbCCBHinos 

--TABELAS

CREATE TABLE tb_classesHinos(
	pk_Classe_Hino int IDENTITY(1,1),
	vch_Classe varchar(100),
	PRIMARY KEY(pk_Classe_Hino)
)

CREATE TABLE tb_Caminho_Hino(
	pk_Caminho_Hino int IDENTITY(1,1),
	descricao varchar(100),
	PRIMARY KEY(pk_Caminho_Hino)
)

CREATE table db_ccbHinos(
	pk_Numero_Hino int,
	vch_Titulo_Hino varchar(100),
	fk_Classe_Hino int,
	fk_cod_caminho int,
	PRIMARY KEY(pk_Numero_Hino)
	CONSTRAINT FK_Classe_Hino FOREIGN KEY (fk_Classe_Hino)
	REFERENCES tb_classesHinos(pk_Classe_Hino),
	CONSTRAINT FK_Caminho_Hino FOREIGN KEY (fk_cod_caminho)
	REFERENCES tb_Caminho_Hino(pk_Caminho_Hino)
)


--INSERTS

--tb_classesHinos

  INSERT INTO [dbo].[tb_classesHinos](vch_Classe)
  VALUES ('Hinário 1')

  INSERT INTO [dbo].[tb_classesHinos](vch_Classe)
  VALUES ('Hinário 2')

  INSERT INTO [dbo].[tb_classesHinos](vch_Classe)
  VALUES ('Hinário 3')

  INSERT INTO [dbo].[tb_classesHinos](vch_Classe)
  VALUES ('Hinário 4')

  INSERT INTO [dbo].[tb_classesHinos](vch_Classe)
  VALUES ('Hinário 5')
  
--tb_Caminho_Hino
  
  INSERT INTO [dbo].[tb_Caminho_Hino](descricao)
  VALUES ('a-paz_eu_vos_deixo.mp3')
  
  INSERT INTO [dbo].[tb_Caminho_Hino](descricao)
  VALUES ('es_bendito_eternamente.mp3')
  
  INSERT INTO [dbo].[tb_Caminho_Hino](descricao)
  VALUES ('face_a_face_o_verei.mp3')
  
  INSERT INTO [dbo].[tb_Caminho_Hino](descricao)
  VALUES ('seguro_estou....mp3')
  
  INSERT INTO [dbo].[tb_Caminho_Hino](descricao)
  VALUES ('sol_da_justica.mp3')
  
  INSERT INTO [dbo].[tb_Caminho_Hino](descricao)
  VALUES ('sou_servo_inutil__o_deus.mp3')
  
  INSERT INTO [dbo].[tb_Caminho_Hino](descricao)
  VALUES ('cristo_meu_mestre.mp3')
  

--tb_ccbHinos
  
  INSERT INTO [dbo].[db_ccbHinos](pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho)
  VALUES (375,'A paz Eu vos deixo',5,1 )
  
  INSERT INTO [dbo].[db_ccbHinos](pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho)
  VALUES (407,'És bendito eternamente',5,2 )
  
  INSERT INTO [dbo].[db_ccbHinos](pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho)
  VALUES (357,'Face a face o verei',5,3 )
  
  INSERT INTO [dbo].[db_ccbHinos](pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho)
  VALUES (232,'Seguro estou...',5,4 )
  
  INSERT INTO [dbo].[db_ccbHinos](pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho)
  VALUES (44,'Sol da Justiça',5,5 )
  
  INSERT INTO [dbo].[db_ccbHinos](pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho)
  VALUES (260,'Sou servo inútil, ó Deus',5,6 )
  
  INSERT INTO [dbo].[db_ccbHinos](pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho)
  VALUES (1,'Cristo meu Mestre',5,7 )

 

  

  