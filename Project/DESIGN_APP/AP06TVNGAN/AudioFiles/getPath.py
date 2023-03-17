# file này dùng để tạo code query khởi tạo database có tên là AP06TVNGAN và thêm dữ liệu vào table

# Lưu ý:
# thư mục chứa file này chỉ chứa thêm file âm thanh ? lý do: cột mã số trong audiofile không được trùng nhau
# không tồn tại database có sẵn tên là AP06TVNGAN trong server sql
import os
import pathlib
from mutagen.mp3 import MP3

from mutagen.wave import WAVE


def getListFilePath():
    path = os.getcwd()  # get current directory path
    FJoin = os.path.join
    files = [FJoin(path, f) for f in os.listdir(path)]  # list of file in directory
    return files


def standerFilePath(filePath):
    x = filePath.replace("\\", "\\\\")
    return x


def getInfoFile(filePath, index):
    # fileName, fileSize, fileExtention, fileLength = 0

    try:
        fileName = os.path.basename(filePath)

        if fileName == "getPath.py":
            return

        fileSize = os.path.getsize(filePath)
        fileExtention = pathlib.Path(filePath).suffix
        if fileExtention == ".mp3":
            fileLength = round(MP3(filePath).info.length)
        elif fileExtention == ".wav":
            fileLength = round(WAVE(filePath).info.length)
        # fileLength = audiofile.duration(fileName)
        # with audioread.audio_open(fileName) as f:
        #     fileLength = f.
    except:
        fileName = "No file name"
        filePath = "No file path"
        fileSize = 0
        fileExtention = ""
        fileLength = 0
        print("something wrongs at index ", index)

    if fileName != "No file name":
        print(
            "INSERT INTO dbo.AUDIOFILES (ms, filename, filepath, size, ext, length, description)"
        )
        print(
            "VALUES ('{}', '{}', '{}', {}, '{}', {}, 'no desc')".format(
                "0" + str(index) if index < 10 else str(index),
                fileName,
                standerFilePath(filePath),
                round(fileSize / 1024),
                fileExtention,
                fileLength,
            )
        )
    print("\n")


def generateCode():
    index = 1
    header = """
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
    """
    print(header)  # in ra phần code khởi tạo database

    fileList = getListFilePath()

    for filePath in fileList:
        getInfoFile(filePath, index)
        index = index + 1


generateCode()
# getInfoFile("D:\\Lap_trinh_am_thanh\Project\MEDIA\CarHorn\\075714_la-cucaracha-car-hornwav-80095.mp3",1)

# getInfoFile("D:\\Lap_trinh_am_thanh\\Project\\MEDIA\\1.Sound\\GiacMoNgayXua.mp3", 0)
