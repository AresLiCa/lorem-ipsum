# How to.. 

build the container<br />
docker build -t lorem-ipsum:v1 .

//run the container<br />
docker run --rm -d  -p 80:80/tcp lorem-ipsum:v1

//deploy the container to localhost<br />
kubectl apply -f ./kube_lorem-ipsum.yaml

//check the deployment details<br />
kubectl describe deployment nginx-deployment

//list all Pods<br />
kubectl get pods -l app=nginx

//delete the deployment<br />
kubectl delete deployment nginx-deployment


# Ways to scale..
1. Could be done by updating the number of replicas from the kube yaml file.

2. Could also be achieved by applying horizontal autoscale method within Kubenetes

# Sample screenshot
![Alt text](/sample.png?raw=true "Sample")
