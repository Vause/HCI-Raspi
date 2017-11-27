import cv2
import time
import sqlite3

cam = cv2.VideoCapture(0)

cv2.namedWindow("test")
db = sqlite3.connect('HCIRaspi.db')
cursor = db.cursor()
cursor.execute('''SELECT ID, FName, LName, SecurityLevel FROM Employees ORDER BY ID DESC''')
user = cursor.fetchone()

end = time.time() + 2
#img_counter = 0
while True:
    cv2.putText
    ret, frame = cam.read()
    #if ret:
    cv2.imshow("test", frame)
    k = cv2.waitKey(1)
    if k%256 == 27:
           #ESC pressed
           print("Escape hit, closing...")
           #break
    elif k%256 == 32 or time.time() > end:
           #SPACE pressed
           img_name = "data/opencv_frame_{0}_{1}_{2}.png".format(user[1], user[2], user[3])#.format(img_counter)
           cv2.imwrite(img_name, frame)
           print("{} written!".format(img_name))
           #img_counter += 1
           break

cam.release()

cv2.destroyAllWindows()