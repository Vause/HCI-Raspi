import cv2
import numpy as np
import sqlite3
from datetime import datetime

faceRecognizer = cv2.face.LBPHFaceRecognizer_create() #opencv method
faceRecognizer.read('recognizer/trainer.yml') #Look at yml file to recognize face
cascadePath = "haarcascade_frontalface_default.xml" #xml file to tell computer what a face is
faceCascade = cv2.CascadeClassifier(cascadePath); #Cascade Classifier

#make inital connection with db
db = sqlite3.connect('HCIRaspi.db')
cursor = db.cursor()
#cursor = db.cursor()
#users = cursor.fetchall()

#function to get the profile
def getProf(id):
    db = sqlite3.connect('HCIRaspi.db')
    cursor = db.cursor()
    cmd = "SELECT ID, FName, LName, SecurityLevel FROM Employees WHERE ID = " + str(id)
    cursor = db.execute(cmd)
    prof = None
    for row in cursor:
        prof = row
    return prof

#function to insert into the Logs table
def insertIntoLogs(id, lname):
    db = sqlite3.connect('HCIRaspi.db')
    cursor = db.cursor()
    now = datetime.now()
    cmd = "INSERT OR IGNORE INTO Logs (EmployeeID, EmployeeLName, TimeLog, Success) VALUES (?, ?, CURRENT_TIMESTAMP, '1')"
    cursor = db.execute(cmd, (str(id), str(lname)))
    db.commit()

camera = cv2.VideoCapture(0)
font = cv2.FONT_HERSHEY_DUPLEX
while True:
    ret, im = camera.read() #reading from the camera
    gray=cv2.cvtColor(im,cv2.COLOR_BGR2GRAY) #convert what is on the screen to grayscale
    faces=faceCascade.detectMultiScale(gray, 1.2,5) #detect the face in grayscale
    for(x,y,w,h) in faces: #for faces the program finds
        cv2.rectangle(im,(x,y),(x+w,y+h),(225,0,0),2) #draw a rectangle around the face
        Id, confidence = faceRecognizer.predict(gray[y:y+h,x:x+w]) #predict if the face is one it recognizes
        if(confidence < 50):
            profile = getProf(Id) #if person is in the db
            cv2.putText(im, str(profile[1]), (x,y-40), font, 2, (62,180,222), 3) #Put text above the rectangle showing the Employees name
            insertIntoLogs(Id, profile[2]) #insert that record into the logs
        else:
            cv2.putText(im, "Unknown", (x,y-40), font, 2, (62,180,222), 3) #Person is unknown
            insertIntoLogs(0, "Unknown")
    cv2.imshow('Employee Authentication',im) #Camera window
    if cv2.waitKey(10) & 0xFF == ord('q'): #Press q to exit
        break
camera.release()
cv2.destroyAllWindows()