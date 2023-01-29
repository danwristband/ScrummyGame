using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play2 : MonoBehaviour
{
    public GameObject[] choiceArray = new GameObject[6]; //{ accountManagement, chat, payment, product, registeration, userProfile };
    public GameObject first, second, third, fourth, fifth, sixth, seventh;

    public GameObject accountManagement, chat, payment, product, registeration, userProfile;

    public Vector2[] initttPos = new Vector2[6]; //accountInitPos, chatInitPos, paymentInitPos, productInitPos, regisInitPos, profileInitPos;
    public Vector2 accountInitPos, chatInitPos, paymentInitPos, productInitPos, regisInitPos, profileInitPos;

    public int score = 5;
    public Text scoreText;




    public void checkPoint()
    {

        if (product.transform.position == first.transform.position || payment.transform.position == second.transform.position
            && userProfile.transform.position == third.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            SceneManager.LoadScene("FinitePO");

        }

        else if (product.transform.position == first.transform.position || payment.transform.position == third.transform.position
           && userProfile.transform.position == second.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            SceneManager.LoadScene("FinitePO");
        }
        else if (product.transform.position == second.transform.position && payment.transform.position == first.transform.position
            && userProfile.transform.position == third.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            SceneManager.LoadScene("FinitePO");

        }
        else if (product.transform.position == second.transform.position && payment.transform.position == third.transform.position
           && userProfile.transform.position == first.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            SceneManager.LoadScene("FinitePO");
        }
        else if (product.transform.position == third.transform.position && payment.transform.position == second.transform.position
            && userProfile.transform.position == first.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            SceneManager.LoadScene("FinitePO");
        }
        else if (product.transform.position == third.transform.position && payment.transform.position == first.transform.position
           && userProfile.transform.position == second.transform.position)
        {
            scoreText.text = "Score: " + score.ToString() + "Pass";
            SceneManager.LoadScene("FinitePO");
        }
        else
        {
            score--;
            scoreText.text = "Score: " + score.ToString();
            Debug.Log("product" + product.transform.position);
            Debug.Log("first" + first.transform.position);
            Debug.Log(payment.transform.position);
            Debug.Log(second.transform.position);
            Debug.Log(userProfile.transform.position);
            Debug.Log(third.transform.position);

        }



    }

    public void DragChoice(GameObject Choicex)
    {
        Choicex.transform.position = Input.mousePosition;
        Choicex.transform.SetAsLastSibling();

    }

    public void DropChoice()
    {
        Debug.Log(choiceArray);
        Debug.Log(initttPos);
        switchCalculator(choiceArray, initttPos);

       
    }



    public void switchCalculator(GameObject[] choice, Vector2[] b)
    {
        Vector2 Position1, Position2;


        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                float Distance = Vector2.Distance(choice[i].transform.position, choice[j].transform.position);

                if (Distance < 100)
                {

                    Position1 = b[i];
                    Position2 = b[j];

                    choice[j].transform.position = Position1;
                    choice[i].transform.position = Position2;

                    b[i] = Position2;
                    b[j] = Position1;


                }

                else
                    choice[i].transform.position = b[i];

            }



        }


    }





   

    public void DropChoiceProfile()
    {
        float Distance1 = Vector2.Distance(userProfile.transform.position, accountInitPos);
        float Distance2 = Vector2.Distance(userProfile.transform.position, chatInitPos);
        float Distance3 = Vector2.Distance(userProfile.transform.position, paymentInitPos);
        float Distance4 = Vector2.Distance(userProfile.transform.position, productInitPos);
        float Distance5 = Vector2.Distance(userProfile.transform.position, regisInitPos);


        Vector2 position;



        if (Distance1 < 30)
        {
            position = profileInitPos;

            userProfile.transform.position = accountInitPos;
            profileInitPos = accountInitPos;

            accountManagement.transform.position = position;
            accountInitPos = position;

        }

        else if (Distance2 < 30)
        {

            position = profileInitPos;

            userProfile.transform.position = chatInitPos;
            profileInitPos = chatInitPos;

            chat.transform.position = position;
            chatInitPos = position;



        }
        else if (Distance3 < 30)
        {
            position = profileInitPos;

            userProfile.transform.position = paymentInitPos;
            profileInitPos = paymentInitPos;
            payment.transform.position = position;
            paymentInitPos = position;


        }
        else if (Distance4 < 30)
        {

            position = profileInitPos;

            userProfile.transform.position = productInitPos;
            profileInitPos = productInitPos;
            product.transform.position = position;
            productInitPos = position;

        }
        else if (Distance5 < 30)
        {
            position = profileInitPos;

            userProfile.transform.position = regisInitPos;
            profileInitPos = regisInitPos;
            registeration.transform.position = position;
            regisInitPos = position;

        }


        else
        {
            userProfile.transform.position = profileInitPos;
        }


    }



    public void DropChoiceRegis()

    {
        float Distance1 = Vector2.Distance(registeration.transform.position, accountInitPos);
        float Distance2 = Vector2.Distance(registeration.transform.position, chatInitPos);
        float Distance3 = Vector2.Distance(registeration.transform.position, paymentInitPos);
        float Distance4 = Vector2.Distance(registeration.transform.position, productInitPos);
        float Distance6 = Vector2.Distance(registeration.transform.position, profileInitPos);

        Vector2 position;



        if (Distance1 < 30)
        {
            position = regisInitPos;

            registeration.transform.position = accountInitPos;
            regisInitPos = accountInitPos;

            accountManagement.transform.position = position;
            accountInitPos = position;

        }
        else if (Distance2 < 30)
        {
            Debug.Log(regisInitPos);
            position = regisInitPos;

            registeration.transform.position = chatInitPos;
            regisInitPos = chatInitPos;

            chat.transform.position = position;
            chatInitPos = position;



        }
        else if (Distance3 < 30)
        {
            position = regisInitPos;

            registeration.transform.position = paymentInitPos;
            regisInitPos = paymentInitPos;
            payment.transform.position = position;
            paymentInitPos = position;


        }
        else if (Distance4 < 30)
        {

            position = regisInitPos;

            registeration.transform.position = productInitPos;
            regisInitPos = productInitPos;
            product.transform.position = position;
            productInitPos = position;

        }

        else if (Distance6 < 30)
        {
            position = regisInitPos;

            registeration.transform.position = profileInitPos;
            regisInitPos = profileInitPos;
            userProfile.transform.position = position;
            profileInitPos = position;
        }

        else
        {
            registeration.transform.position = regisInitPos;
        }


    }

    
        public void DropChoiceAccount()
        {
            
            float Distance2 = Vector2.Distance(accountManagement.transform.position, chatInitPos);
            float Distance3 = Vector2.Distance(accountManagement.transform.position, paymentInitPos);
            float Distance4 = Vector2.Distance(accountManagement.transform.position, productInitPos);
            float Distance5 = Vector2.Distance(accountManagement.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(accountManagement.transform.position, profileInitPos);

            Vector2 position;


             if (Distance2 < 30)
            {
                Debug.Log(accountInitPos);
                position = accountInitPos;

                accountManagement.transform.position = chatInitPos;
                accountInitPos = chatInitPos;

                chat.transform.position = position;
                chatInitPos = position;



            }
            else if (Distance3 < 30)
            {
                position = accountInitPos;

                accountManagement.transform.position = paymentInitPos;
                accountInitPos = paymentInitPos;
                payment.transform.position = position;
                paymentInitPos = position;


            }
            else if (Distance4 < 30)
            {

                position = accountInitPos;

                accountManagement.transform.position = productInitPos;
                accountInitPos = productInitPos;
                product.transform.position = position;
                productInitPos = position;

            }
            else if (Distance5 < 30)
            {
                position = accountInitPos;

                accountManagement.transform.position = regisInitPos;
                accountInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 30)
            {
                position = accountInitPos;

                accountManagement.transform.position = profileInitPos;
                accountInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                accountManagement.transform.position = accountInitPos;
            }


        }
    
        public void DropChoiceChat()
        {
            float Distance1 = Vector2.Distance(chat.transform.position, accountInitPos);
            float Distance3 = Vector2.Distance(chat.transform.position, paymentInitPos);
            float Distance4 = Vector2.Distance(chat.transform.position, productInitPos);
            float Distance5 = Vector2.Distance(chat.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(chat.transform.position, profileInitPos);

            Vector2 position;



            if (Distance1 < 30)
            {
                position = chatInitPos;

                chat.transform.position = accountInitPos;
                chatInitPos = accountInitPos;

                accountManagement.transform.position = position;
                accountInitPos = position;

            }
            
            else if (Distance3 < 30)
            {
                position = chatInitPos;

                chat.transform.position = paymentInitPos;
                chatInitPos = paymentInitPos;
                payment.transform.position = position;
                paymentInitPos = position;


            }
            else if (Distance4 < 30)
            {

                position = chatInitPos;

                chat.transform.position = productInitPos;
                chatInitPos = productInitPos;
                product.transform.position = position;
                productInitPos = position;

            }
            else if (Distance5 < 30)
            {
                position = chatInitPos;

                chat.transform.position = regisInitPos;
                chatInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 30)
            {
                position = chatInitPos;

                chat.transform.position = profileInitPos;
                chatInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                chat.transform.position = chatInitPos;
            }


        }

    
        public void DropChoicePayment()
        {
            float Distance1 = Vector2.Distance(payment.transform.position, accountInitPos);
            float Distance2 = Vector2.Distance(payment.transform.position, chatInitPos);
            float Distance4 = Vector2.Distance(payment.transform.position, productInitPos);
            float Distance5 = Vector2.Distance(payment.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(payment.transform.position, profileInitPos);

            Vector2 position;



            if (Distance1 < 30)
            {
                position = paymentInitPos;

                payment.transform.position = accountInitPos;
                paymentInitPos = accountInitPos;

                accountManagement.transform.position = position;
                accountInitPos = position;

            }
            else if (Distance2 < 30)
            {
                Debug.Log(paymentInitPos);
                position = paymentInitPos;

                payment.transform.position = chatInitPos;
                paymentInitPos = chatInitPos;

                chat.transform.position = position;
                chatInitPos = position;



            }
           
            else if (Distance4 < 30)
            {

                position = paymentInitPos;

                payment.transform.position = productInitPos;
                paymentInitPos = productInitPos;
                product.transform.position = position;
                productInitPos = position;

            }
            else if (Distance5 < 30)
            {
                position = paymentInitPos;

                payment.transform.position = regisInitPos;
                paymentInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 30)
            {
                position = paymentInitPos;

                payment.transform.position = profileInitPos;
                paymentInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                payment.transform.position = paymentInitPos;
            }


        }
    
        public void DropChoiceProduct()
        {
            float Distance1 = Vector2.Distance(product.transform.position, accountInitPos);
            float Distance2 = Vector2.Distance(product.transform.position, chatInitPos);
            float Distance3 = Vector2.Distance(product.transform.position, paymentInitPos);
            float Distance5 = Vector2.Distance(product.transform.position, regisInitPos);
            float Distance6 = Vector2.Distance(product.transform.position, profileInitPos);

            Vector2 position;



            if (Distance1 < 30)
            {
                position = productInitPos;

                product.transform.position = accountInitPos;
                productInitPos = accountInitPos;

                accountManagement.transform.position = position;
                accountInitPos = position;

            }
            else if (Distance2 < 30)
            {
                Debug.Log(productInitPos);
                position = productInitPos;

                product.transform.position = chatInitPos;
                productInitPos = chatInitPos;

                chat.transform.position = position;
                chatInitPos = position;



            }
            else if (Distance3 < 30)
            {
                position = productInitPos;

                product.transform.position = paymentInitPos;
                productInitPos = paymentInitPos;
                payment.transform.position = position;
                paymentInitPos = position;


            }
            
            else if (Distance5 < 20)
            {
                position = productInitPos;

                product.transform.position = regisInitPos;
                productInitPos = regisInitPos;
                registeration.transform.position = position;
                regisInitPos = position;

            }
            else if (Distance6 < 30)
            {
                position = productInitPos;

                product.transform.position = profileInitPos;
                productInitPos = profileInitPos;
                userProfile.transform.position = position;
                profileInitPos = position;
            }

            else
            {
                product.transform.position = productInitPos;
            }


        }


        


    // Start is called before the first frame update
    void Start()
    {



        for (int i = 0; i < 6; i++)
        {
            initttPos[i] = choiceArray[i].transform.position;



        }

        accountInitPos = accountManagement.transform.position;
        chatInitPos = chat.transform.position;
        paymentInitPos = payment.transform.position;
        productInitPos = product.transform.position;
        regisInitPos = registeration.transform.position;
        profileInitPos = userProfile.transform.position;


    }



}
