import cv2, sys
import sqlite3
camera = cv2.VideoCapture(0)
faceDetector=cv2.CascadeClassifier('haarcascade_frontalface_default.xml')

db = sqlite3.connect('HCIRaspi.db')
cursor = db.cursor()
cursor.execute('''SELECT ID, FName, LName, SecurityLevel FROM Employees ORDER BY ID DESC''')
user = cursor.fetchone()
Id = user[0]
sampleSize = 0
while(True):
    ret, img = camera.read()
    grayScale = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    faces = faceDetector.detectMultiScale(grayScale, 1.3, 5)
    for (x,y,w,h) in faces:
        cv2.rectangle(img,(x,y),(x+w,y+h),(255,0,0),2)
        
        #incrementing sample number 
        sampleSize += 1
        #saving the captured face in the dataset folder
        cv2.imwrite("dataSet/User."+ str(Id) +'.'+ str(sampleSize) + ".jpg", grayScale[y:y+h,x:x+w])
        if(sampleSize == 5):
            cv2.imwrite("data/opencv_frame_{0}_{1}_{2}.png".format(user[1], user[2], user[3]), grayScale[y:y+h,x:x+w])
        cv2.imshow('Face Capture',img)
    #wait for 100 miliseconds or if the user presses the 'q' key
    if cv2.waitKey(100) & 0xFF == ord('q'):
        break
    # break if the sample number is more than 20
    elif sampleSize > 40:
        break
camera.release()
cv2.destroyAllWindows()