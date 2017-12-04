import cv2
import numpy as np
import sqlite3
from datetime import datetime

faceRecognizer = cv2.face.LBPHFaceRecognizer_create()
faceRecognizer.read('recognizer/trainer.yml')
cascadePath = "haarcascade_frontalface_default.xml"
faceCascade = cv2.CascadeClassifier(cascadePath);

db = sqlite3.connect('HCIRaspi.db')
cursor = db.cursor()
#cursor = db.cursor()
#users = cursor.fetchall()

def getProf(id):
    db = sqlite3.connect('HCIRaspi.db')
    cursor = db.cursor()
    cmd = "SELECT ID, FName, LName, SecurityLevel FROM Employees WHERE ID = " + str(id)
    cursor = db.execute(cmd)
    prof = None
    for row in cursor:
        prof = row
    return prof

def insertIntoLogs(id, lname):
    db = sqlite3.connect('HCIRaspi.db')
    cursor = db.cursor()
    now = datetime.now()
    cmd = "INSERT INTO Logs (EmployeeID, EmployeeLName, TimeLog, Success) VALUES (?, ?, CURRENT_TIMESTAMP, '1')"
    cursor = db.execute(cmd, (str(id), str(lname)))
    db.commit()

camera = cv2.VideoCapture(0)
font = cv2.FONT_HERSHEY_DUPLEX
while True:
    ret, im = camera.read()
    gray=cv2.cvtColor(im,cv2.COLOR_BGR2GRAY)
    faces=faceCascade.detectMultiScale(gray, 1.2,5)
    for(x,y,w,h) in faces:
        cv2.rectangle(im,(x,y),(x+w,y+h),(225,0,0),2)
        Id, confidence = faceRecognizer.predict(gray[y:y+h,x:x+w])
        if(confidence < 50):
            profile = getProf(Id)
            cv2.putText(im, str(profile[1]), (x,y-40), font, 2, (62,180,222), 3)
            insertIntoLogs(Id, profile[2])
        else:
            cv2.putText(im, "Unknown", (x,y-40), font, 2, (62,180,222), 3)
            insertIntoLogs(0, "Unknown")
    cv2.imshow('Employee Authentication',im) 
    if cv2.waitKey(10) & 0xFF == ord('q'):
        break
camera.release()
cv2.destroyAllWindows()