CREATE DATABASE AP06TVNGAN
GO
CREATE TABLE AUDIOFILES
(
    ms NCHAR(20) NOT NULL PRIMARY KEY,
    filename NCHAR(100),
    filepath NCHAR(150),
    size float,
    ext NCHAR(10),
    length int,
    description NVARCHAR(150)
)
GO
    
INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('01', '044197_2013-dodge-charger-car-horn-wav-72822.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\044197_2013-dodge-charger-car-horn-wav-72822.mp3', 352, '.mp3', 18, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('02', '075714_la-cucaracha-car-hornwav-80095.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\075714_la-cucaracha-car-hornwav-80095.mp3', 94, '.mp3', 3, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('03', '086287_car-horn_eu1wav-37254.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\086287_car-horn_eu1wav-37254.mp3', 20, '.mp3', 1, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('04', '182474__keweldog__car-horn.wav', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\182474__keweldog__car-horn.wav', 745, '.wav', 4, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('05', '2000-nissan-maxima-car-horn-72828.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\2000-nissan-maxima-car-horn-72828.mp3', 281, '.mp3', 14, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('06', '20131210_car-horn_zoomh2nxy-75008.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\20131210_car-horn_zoomh2nxy-75008.mp3', 307, '.mp3', 16, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('07', '402958__inspectorj__car-alarm-horn-walking-past-a.wav', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\402958__inspectorj__car-alarm-horn-walking-past-a.wav', 6527, '.wav', 25, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('08', 'boedie_alfa_romeo_mito_honking_car_horn-7138.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\boedie_alfa_romeo_mito_honking_car_horn-7138.mp3', 134, '.mp3', 7, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('09', 'car-honk-mus-152-94478.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\car-honk-mus-152-94478.mp3', 228, '.mp3', 7, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('10', 'car-horn-6408.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\car-horn-6408.mp3', 83, '.mp3', 4, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('11', 'car-horn-90973.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\car-horn-90973.mp3', 255, '.mp3', 8, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('12', 'car-horn-beep-beep-two-beeps-honk-honk-6188.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\car-horn-beep-beep-two-beeps-honk-honk-6188.mp3', 23, '.mp3', 1, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('13', 'car-horn-beepsmp3-14659.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\car-horn-beepsmp3-14659.mp3', 50, '.mp3', 3, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('14', 'car-horn-mercury-marquis-36979.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\car-horn-mercury-marquis-36979.mp3', 60, '.mp3', 3, 'no desc')


INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)
VALUES ('15', 'car-horns-73144.mp3', 'c:\\Program Files\\TVNGAN\\AUDIO_DATA\\car-horns-73144.mp3', 311, '.mp3', 16, 'no desc')