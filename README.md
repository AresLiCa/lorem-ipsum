How to.. 

# build the container
docker build -t lorem-ipsum:v1 .

# run the container
docker run --rm -d  -p 80:80/tcp lorem-ipsum:v1

# deploy the container to localhost
kubectl apply -f ./kube_lorem-ipsum.yaml

# check the deployment details
kubectl describe deployment nginx-deployment

# list all Pods
kubectl get pods -l app=nginx

# delete the deployment
kubectl delete deployment nginx-deployment


Ways to scale..
# Could be done by updating the number of replicas from the kube yaml file.

# Could also be achieved by applying horizontal autoscale method within Kubenetes


