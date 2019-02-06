package test;

import org.junit.Test;
import Renderer.ImageWriter;
import java.util.Random;

import static org.junit.Assert.*;

/**
 * Created by HC on 13/06/2017.
 */
public class ImageWriterTest {
    @Test
    public void writeToimage() {
        ImageWriter imageWriter = new ImageWriter("Image writer test", 600, 500, 1, 1);
        Random rand = new Random();
        for (int i = 0; i < imageWriter.getHeight(); i++) {
            for (int j = 0; j < imageWriter.getWidth(); j++) {
                if (j <= 200)
                    imageWriter.writePixel(j, i, 0, 0, 255); // BLUE
                else if (j > 200 && j <= 400)
                    imageWriter.writePixel(j, i, 255, 255, 255); // WHITE
                else if (j > 400 && j <= 600)
                    imageWriter.writePixel(j, i, 255, 0, 0); // RED
            }
            imageWriter.writeToimage();


        }
    }

}