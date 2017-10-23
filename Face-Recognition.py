import cv2
import numpy as np

faceRecognizer = cv2.face.LBPHFaceRecognizer_create()
faceRecognizer.read('recognizer/trainer.yml')
cascadePath = "haarcascade_frontalface_default.xml"
faceCascade = cv2.CascadeClassifier(cascadePath);


camera = cv2.VideoCapture(0)
font = cv2.FONT_HERSHEY_DUPLEX#FONT_HERSHEY_SIMPLEX
while True:
    ret, im = camera.read()
    gray=cv2.cvtColor(im,cv2.COLOR_BGR2GRAY)
    faces=faceCascade.detectMultiScale(gray, 1.2,5)
    for(x,y,w,h) in faces:
        cv2.rectangle(im,(x,y),(x+w,y+h),(225,0,0),2)
        Id, confidence = faceRecognizer.predict(gray[y:y+h,x:x+w])
        if(confidence < 50):
            if(Id==1):
                Id="Ruben"
            elif(Id==2):
                Id="Cat"
        else:
            Id="Unknown"
        cv2.putText(im, str(Id), (x,y-40), font, 2, (62,180,222), 3)
    cv2.imshow('im',im) 
    if cv2.waitKey(10) & 0xFF == ord('q'):
        break
camera.release()
cv2.destroyAllWindows()