import cv2
import time

cam = cv2.VideoCapture(0)

cv2.namedWindow("test")

end = time.time() + 3
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
           img_name = "data/opencv_frame.png"#.format(img_counter)
           cv2.imwrite(img_name, frame)
           print("{} written!".format(img_name))
           #img_counter += 1
           break

cam.release()

cv2.destroyAllWindows()